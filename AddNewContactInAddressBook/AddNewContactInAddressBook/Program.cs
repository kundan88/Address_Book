using System;
using System.Collections;
using System.Collections.Generic;


class ContactDetails
{
    public string firstName;
    public string lastName;
    public string address;
    public string email;
    public string city;
    public int phoneNumber;
    public string state;
    public int zip;

    public ContactDetails(string firstName, string lastName, string address, string email, string city, int phoneNumber, string state, int zip)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.address = address;
        this.email = email;
        this.city = city;
        this.phoneNumber = phoneNumber;
        this.state = state;
        this.zip = zip;


    }
    public string ToString()
    {
        return " Details Of " + firstName + " " + lastName + " are:" + "address:" + address + "City:" + city + "\n"
                            + "    " + "state" + state + "zip" + zip + "\n"
                            + "    " + "phoneNumber :" + phoneNumber + "\n"
                            + "   " + "email:" + email;
    }
}