package spring_example.service;

import java.util.List;

import spring_example.model.User;

public interface UserService {

 public List listAllUsers();
 
 public void addUser(User user);
 
 public void updateUser(User user);
 
 public void deleteUser(int id);
 
 public User findUserById(int id);
}