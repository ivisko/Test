package spring_example.dao;

import java.util.List;

import spring_example.model.User;

public interface UserDao {
 
 public List<User> listAllUsers();
 
 public void addUser(User user);
 
 public void updateUser(User user);
 
 public void deleteUser(int id);
 
 public User findUserById(int id);
}