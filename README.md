# discountManager

Swagger Module Is Enabled From Default

##Run
You can run the project from directly from Visual Studio or from docker

### Post Request to 
https://localhost:44386/api/Carts/{id}
[BODY]
{
  "items": [
    {
      "count": 1,
      "item": {
        "name": "Lettuce",
        "price": 100,
        "type": "GR"//needs to be GR so it counted as Groceries in the filtering
      }
    },
    {
      "count": 1,
      "item": {
        "name": "HDMI",
        "price": 100,
        "type": "Tech"
      }
    }
  ]
}

id is translated to user status as if user is employee, affiliate or loyalCustomer
1 -> Affiliate

2 -> Employe

3 -> LoyalCustomer

### Patterns
Strategy Pattern is used to create all discount type so furter types and discounts can be added with minimal distruption
Solid factory to generate the cash and discount based strategy


###Logging

Basic HTTP logging 

 ## Further Improvments
 - Project does not use any kind of validation for items or its types 
 - No databases are involved in the project 
 - Might need to insert and check the items from database for some kind of validation and prevent tampering with prices
 - Logging is done via default HTTPLogger might need to use a middleware to cach error and log incoming requests before and after
 - No authentication since there is no database of users need to add user and login module to automaticly decide user status
