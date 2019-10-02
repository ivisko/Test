//Spring MVC Kontroler
package sk.rajnoha.customer;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.servlet.ModelAndView;

@Controller
public class CustomerController {
	@Autowired
	private CustomerService service;
	 
	@RequestMapping("/")
	public ModelAndView home() {
		ModelAndView mav = new ModelAndView("index");
		 List<Customer> listCustomer = service.ListAll();
		mav.addObject("listCustomer", listCustomer);
		return mav;
	}
	
}
