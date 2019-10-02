
import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import java.util.*;

class Hadik extends JFrame implements KeyListener, Runnable {

    JPanel p1, p2;
    JButton[] lb = new JButton[200];
    JButton bonusfood;
    JTextArea t;
    int x = 500, y = 250, gu = 2, directionx = 1, directiony = 0, speed =75, difference = 0, oldx, oldy, score = 0;
    int[] lbx = new int[300];
    int[] lby = new int[300];
    Point[] lbp = new Point[300];
    Point bfp = new Point();
    Thread myt;
    boolean food = false, runl = false, runr = true, runu = true, rund = true, bonusflag = true;
    Random r = new Random();
    JMenuBar mymbar;
    JMenu game, help;

    public void initializeValues() {
        gu = 3;
        lbx[0] = 100;
        lby[0] = 150;
        directionx = 10;
        directiony = 0;
        difference = 0;
        score = 0;
        food = false;
        runl = false;
        runr = true;
        runu = true;
        rund = true;
        bonusflag = true;
    }

    Hadik() {
        super("Hadik :)");
        setSize(500, 330);
        
        creatbar();
        
        initializeValues();
        
        p1 = new JPanel();
        p2 = new JPanel();
        
        t = new JTextArea("Tvoj pocet bodov :" + score);
        t.setEnabled(false);
        t.setBackground(Color.DARK_GRAY);
        
        bonusfood = new JButton();
        bonusfood.setEnabled(false);
        
        createFirstSnake();

        p1.setLayout(null);
        p2.setLayout(new GridLayout(0, 1));
        p1.setBounds(0, 0, x, y);
        p1.setBackground(Color.green);
        p2.setBounds(0, y, x, 30);
        p2.setBackground(Color.BLUE);

        p2.add(t); 
        
        getContentPane().setLayout(null);
        getContentPane().add(p1);
        getContentPane().add(p2);

        show();
        setDefaultCloseOperation(EXIT_ON_CLOSE);

        addKeyListener(this);
        
        myt = new Thread(this);
        myt.start(); 
    }

    public void createFirstSnake() {
        
        for (int i = 0; i < 3; i++) {
            lb[i] = new JButton(" " + i);
            lb[i].setEnabled(false);
            p1.add(lb[i]);
            lb[i].setBounds(lbx[i], lby[i], 10, 10);
            lbx[i + 1] = lbx[i] - 10;
            lby[i + 1] = lby[i];
        }
    }

    public void creatbar() {
        mymbar = new JMenuBar();

        game = new JMenu("Hra");

        JMenuItem newgame = new JMenuItem("Nova hra");
        JMenuItem exit = new JMenuItem("Konec");

        newgame.addActionListener(
                new ActionListener() {

                    public void actionPerformed(ActionEvent e) {
                        reset();
                    }
                });

        exit.addActionListener(new ActionListener() {

            public void actionPerformed(ActionEvent e) {
                System.exit(0);
            }
        });

        game.add(newgame);
        game.addSeparator();
        game.add(exit);

        mymbar.add(game);


        help = new JMenu("Pomoc");

        JMenuItem creator = new JMenuItem("Tvorca");


        creator.addActionListener(new ActionListener() {

            public void actionPerformed(ActionEvent e) {
                JOptionPane.showMessageDialog(p2, "Name: Iive");
            }
        });

        help.add(creator);

        mymbar.add(help);

        setJMenuBar(mymbar);
    }

    void reset() {
        initializeValues();
        p1.removeAll();

        myt.stop();

        createFirstSnake();
        t.setText("Tvoj pocet bodov :" + score);

        myt = new Thread(this);
        myt.start();
    }

    void growup() {
        lb[gu] = new JButton();
        lb[gu].setEnabled(false);
        p1.add(lb[gu]);

        int a = 10 + (10 * r.nextInt(48));
        int b = 10 + (10 * r.nextInt(23));

        lbx[gu] = a;
        lby[gu] = b;
        lb[gu].setBounds(a, b, 10, 10);

        gu++;
    }
   
    void moveForward() {
        for (int i = 0; i < gu; i++) {
            lbp[i] = lb[i].getLocation();
        }

        lbx[0] += directionx;
        lby[0] += directiony;
        lb[0].setBounds(lbx[0], lby[0], 10, 10);

        for (int i = 1; i < gu; i++) {
            lb[i].setLocation(lbp[i - 1]);
        }

        if (lbx[0] == x) {
            lbx[0] = 10;
        } else if (lbx[0] == 0) {
            lbx[0] = x - 10;
        } else if (lby[0] == y) {
            lby[0] = 10;
        } else if (lby[0] == 0) {
            lby[0] = y - 10;
        }

        if (lbx[0] == lbx[gu - 1] && lby[0] == lby[gu - 1]) {
            food = false;
            score += 5;
            t.setText("Tvoj pocet bodov :" + score);
            if (score % 50 == 0 && bonusflag == true) {
                p1.add(bonusfood);
                bonusfood.setBounds((10 * r.nextInt(50)), (10 * r.nextInt(25)), 15, 15);
                bfp = bonusfood.getLocation();
                bonusflag = false;
            }
        }

        if (bonusflag == false) {
            if (bfp.x <= lbx[0] && bfp.y <= lby[0] && bfp.x + 10 >= lbx[0] && bfp.y + 10 >= lby[0]) {
                p1.remove(bonusfood);
                score += 100;
                t.setText("Tvoj pocet bodov :" + score);
                bonusflag = true;
            }
        }

        if (food == false) {
            growup();
            food = true;
        } else {
            lb[gu - 1].setBounds(lbx[gu - 1], lby[gu - 1], 10, 10);
        }

        for (int i = 1; i < gu; i++) {
            if (lbp[0] == lbp[i]) {
                t.setText("Koniec Hry" + score);
                try {
                    myt.join();
                } catch (InterruptedException ie) {
                }
                break;
            }
        }


        p1.repaint();
        show();
    }

    public void keyPressed(KeyEvent e) {
        
        if (runl == true && e.getKeyCode() == 37) {
            directionx = -10; 
            directiony = 0;
            runr = false;     
            runu = true;      
            rund = true;      
        }
        
        if (runu == true && e.getKeyCode() == 38) {
            directionx = 0;
            directiony = -10; 
            rund = false;     
            runr = true;      
            runl = true;      
        }
        
        if (runr == true && e.getKeyCode() == 39) {
            directionx = +10; 
            directiony = 0;
            runl = false;
            runu = true;
            rund = true;
        }
        
        if (rund == true && e.getKeyCode() == 40) {
            directionx = 0;
            directiony = +10; 
            runu = false;
            runr = true;
            runl = true;
        }
    }

    public void keyReleased(KeyEvent e) {
    }

    public void keyTyped(KeyEvent e) {
    }

    public void run() {
        for (;;) {
            moveForward();
            try {
                Thread.sleep(speed);
            } catch (InterruptedException ie) {
            }
        }
    }
}
