/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package oprvocislach;

import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.SwingUtilities;


public class Okno extends javax.swing.JFrame {

    private Thread[] thread = null;
    private int[] vypPrvocisiel;
    long beh = 0;

    private class resolution implements Runnable {

        int sucet = 0;
        long startTime = System.currentTimeMillis();
        long endTime = 0;

        public void run() {

            for (Thread i : thread) {
                try {
                    i.join();
                } catch (InterruptedException ex) {
                    Logger.getLogger(Okno.class.getName()).log(Level.SEVERE, null, ex);
                }
            }

            for (int i : vypPrvocisiel) {
                sucet += i;
            }

            endTime = System.currentTimeMillis();

            jTextArea2.append("the end " + sucet + " prvocisiel s casom hladania " + (endTime - startTime) + " ms");
        }
    }

    private class PocitacPrvocisiel implements Runnable {

        private int a;
        private int b;
        private int prvok;

        public PocitacPrvocisiel(int a, int b, int prvok) {
            this.a = a;
            this.b = b;
            this.prvok = prvok;
        }

        private void updateProgressBar(final int hodnota) {
            SwingUtilities.invokeLater(new Runnable() {
                public void run() {
                    jProgressBar1.setValue(hodnota);
                }
            });

        }

        public void run() {
            long start = System.currentTimeMillis();

            int numFound = 0;
            for (int cislo = this.a; cislo <= this.b; cislo++) {
                if (Thread.interrupted()) {
                    jTextArea2.append("the end ");
                    return;
                }

                boolean je = true;
                for (int d = 2; d <= cislo / 2; d++) {
                    if (cislo % d == 0) {
                        je = false;
                        break;
                    }
                }

                if (je) {
                    numFound++;
                }

                if (this.prvok == vypPrvocisiel.length - 1) {
                    if (cislo % 100 == 0) {
                        updateProgressBar((int) ((100.0) * (cislo - this.a + 1) / (this.b - this.a + 1)));
                    }
                }

                if (this.prvok == 0) {
                    jProgressBar2.setValue((int) ((100.0) * (cislo - this.a + 1) / (this.b - this.a + 1)));
                }
                if (this.prvok == 1) {
                    jProgressBar3.setValue((int) ((100.0) * (cislo - this.a + 1) / (this.b - this.a + 1)));
                }
                if (this.prvok == 2) {
                    jProgressBar4.setValue((int) ((100.0) * (cislo - this.a + 1) / (this.b - this.a + 1)));
                }
                if (this.prvok == 3) {
                    jProgressBar5.setValue((int) ((100.0) * (cislo - this.a + 1) / (this.b - this.a + 1)));
                }
                if (this.prvok == 4) {
                    jProgressBar6.setValue((int) ((100.0) * (cislo - this.a + 1) / (this.b - this.a + 1)));
                }
            }

            long end = System.currentTimeMillis();
            vypPrvocisiel[this.prvok] = numFound;
            jTextArea2.append(Thread.currentThread().getName() + " najdenych : " + vypPrvocisiel[this.prvok]
                    + " prvocisiel, cas hladania " + (end - start) + " ms" + "\n");
        }
    }

    /**
     * Creates new form Okno
     */
    public Okno() {
        initComponents();
    }

   
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jScrollPane1 = new javax.swing.JScrollPane();
        jTextArea1 = new javax.swing.JTextArea();
        jTextField1 = new javax.swing.JTextField();
        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        jTextField2 = new javax.swing.JTextField();
        jButton1 = new javax.swing.JButton();
        jButton2 = new javax.swing.JButton();
        jLabel3 = new javax.swing.JLabel();
        jProgressBar1 = new javax.swing.JProgressBar();
        jTextField3 = new javax.swing.JTextField();
        jLabel4 = new javax.swing.JLabel();
        jScrollPane2 = new javax.swing.JScrollPane();
        jTextArea2 = new javax.swing.JTextArea();
        jProgressBar2 = new javax.swing.JProgressBar();
        jProgressBar3 = new javax.swing.JProgressBar();
        jProgressBar4 = new javax.swing.JProgressBar();
        jProgressBar5 = new javax.swing.JProgressBar();
        jProgressBar6 = new javax.swing.JProgressBar();

        jTextArea1.setColumns(20);
        jTextArea1.setRows(5);
        jScrollPane1.setViewportView(jTextArea1);

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Kolko je prvocisiel?");

        jTextField1.setText("1");

        jLabel1.setText("dolna¡ hranica cisiel");

        jLabel2.setText("horna¡ hranica cisiel");

        jTextField2.setText("200000");
        jTextField2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jTextField2ActionPerformed(evt);
            }
        });

        jButton1.setText("start");
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });

        jButton2.setText("stop");
        jButton2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton2ActionPerformed(evt);
            }
        });

        jProgressBar1.setStringPainted(true);

        jTextField3.setText("5");

        jLabel4.setText("početet vlakien ");

        jTextArea2.setColumns(20);
        jTextArea2.setRows(5);
        jScrollPane2.setViewportView(jTextArea2);

        jProgressBar2.setToolTipText("");
        jProgressBar2.setStringPainted(true);

        jProgressBar3.setStringPainted(true);

        jProgressBar4.setStringPainted(true);

        jProgressBar5.setStringPainted(true);

        jProgressBar6.setStringPainted(true);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(70, 70, 70)
                        .addComponent(jLabel3))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(21, 21, 21)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                                .addGroup(layout.createSequentialGroup()
                                    .addComponent(jLabel1)
                                    .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                    .addComponent(jTextField1, javax.swing.GroupLayout.PREFERRED_SIZE, 79, javax.swing.GroupLayout.PREFERRED_SIZE))
                                .addGroup(javax.swing.GroupLayout.Alignment.LEADING, layout.createSequentialGroup()
                                    .addComponent(jLabel4)
                                    .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                    .addComponent(jTextField3, javax.swing.GroupLayout.PREFERRED_SIZE, 79, javax.swing.GroupLayout.PREFERRED_SIZE))
                                .addGroup(javax.swing.GroupLayout.Alignment.LEADING, layout.createSequentialGroup()
                                    .addComponent(jLabel2)
                                    .addGap(18, 18, 18)
                                    .addComponent(jTextField2, javax.swing.GroupLayout.PREFERRED_SIZE, 79, javax.swing.GroupLayout.PREFERRED_SIZE)))
                            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                                .addComponent(jProgressBar6, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, 276, Short.MAX_VALUE)
                                .addComponent(jProgressBar5, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                .addComponent(jProgressBar4, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                .addComponent(jProgressBar3, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                .addComponent(jProgressBar2, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                            .addGroup(layout.createSequentialGroup()
                                .addComponent(jButton1)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addComponent(jButton2)))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jProgressBar1, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.PREFERRED_SIZE, 390, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jScrollPane2, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.PREFERRED_SIZE, 390, javax.swing.GroupLayout.PREFERRED_SIZE))))
                .addGap(51, 51, 51))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jTextField1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jLabel1))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jLabel2)
                            .addComponent(jTextField2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(2, 2, 2)
                        .addComponent(jProgressBar1, javax.swing.GroupLayout.DEFAULT_SIZE, 51, Short.MAX_VALUE)))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jTextField3, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jLabel4))
                        .addGap(37, 37, 37)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jButton1)
                            .addComponent(jButton2))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(jProgressBar2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(jProgressBar3, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(jProgressBar4, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(jProgressBar5, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(jProgressBar6, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addComponent(jScrollPane2))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addComponent(jLabel3)
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed

        jLabel3.setText("");
        jProgressBar1.setValue(0);
        jProgressBar2.setValue(0);
        jProgressBar3.setValue(0);
        jProgressBar4.setValue(0);
        jProgressBar5.setValue(0);
        jProgressBar6.setValue(0);

        jTextArea2.setText(null);

        int dh = Integer.parseInt(jTextField1.getText());
        int hh = Integer.parseInt(jTextField2.getText());
        int pt = Integer.parseInt(jTextField3.getText());
        thread = new Thread[pt];
        Thread finalresult;
        int rozsah = 0;
        int pridavok = 0;
        int zbytok = 0;
        int zaciatok = 0;
        int koniec = 0;

        vypPrvocisiel = new int[pt];

        if (dh == hh) {
            jTextArea2.setText("nemam co pocitat");
            return;
        }
        if (dh > hh) {
            rozsah = dh - hh;
            pridavok = rozsah / pt;
            zbytok = rozsah % pt;
            zaciatok = hh;
            koniec = hh + pridavok + zbytok;
        } else {
            rozsah = hh - dh;
            pridavok = rozsah / pt;
            zbytok = rozsah % pt;
            zaciatok = dh;
            koniec = dh + pridavok + zbytok;
        }

        for (int i = 0; i < pt; i++) {
            thread[i] = new Thread(new PocitacPrvocisiel(zaciatok, koniec, i));
            thread[i].setName("Vlakno " + i);
            thread[i].start();
            zaciatok = koniec;
            koniec = koniec + pridavok;
        }
        finalresult = new Thread(new resolution());
        finalresult.start();


    }//GEN-LAST:event_jButton1ActionPerformed

    private void jButton2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton2ActionPerformed
        // prerusit ma zmysel len existujuce a pocitajuce vlakno
        for (int i = 0; i < thread.length; i++) {
            if ((thread[i] != null) && (thread[i].isAlive())) {
                thread[i].interrupt();
                thread[i] = null;
            }
        }
    }//GEN-LAST:event_jButton2ActionPerformed

    private void jTextField2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jTextField2ActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_jTextField2ActionPerformed

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {

        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new Okno().setVisible(true);
            }
        });
    }
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jButton1;
    private javax.swing.JButton jButton2;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JProgressBar jProgressBar1;
    private javax.swing.JProgressBar jProgressBar2;
    private javax.swing.JProgressBar jProgressBar3;
    private javax.swing.JProgressBar jProgressBar4;
    private javax.swing.JProgressBar jProgressBar5;
    private javax.swing.JProgressBar jProgressBar6;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JTextArea jTextArea1;
    private javax.swing.JTextArea jTextArea2;
    private javax.swing.JTextField jTextField1;
    private javax.swing.JTextField jTextField2;
    private javax.swing.JTextField jTextField3;
    // End of variables declaration//GEN-END:variables
}
