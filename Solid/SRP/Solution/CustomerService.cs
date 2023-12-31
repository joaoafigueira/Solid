﻿using Solid.SRP.Solution;


public class CustomerService
{
    public string AddCustomer(Customer customer)
    {
        if (!customer.Validate())
            return "Invalid Date";

        var repo = new CustomerRepository();
        repo.AddCustomer(customer);

        EmailService.Send("company@company.com", customer.Email.Address, "Welcome", "Congratulations you're registered");

        return "Customer registered with success";
    }
}