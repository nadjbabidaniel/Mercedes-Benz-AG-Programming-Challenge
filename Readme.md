swagger: “2.0”
----

Rest API needs to be triggered with get http request: http://localhost:54728/v1/Trips/

Authentication is required with next credentials:
 UserName = "MaleUser",          UserName = "FemaleUser"
 Password = "123456"       or    Password = "abcdef"

and VehiclePush object needs to be sent inside of a request body:

Example:

    {
    "vin": "WDD1671591Z000999",
    "breakThreshold": "1800",
    "gasTankSize": "80",
    "data": [
      {
        "timestamp": "1559137020",
        "odometer": "7200",
        "fuelLevel": 52,
        "positionLat": "48.771990",
        "positionLong": "9.172787"
      },
      {
        "timestamp": "1559137020",
        "odometer": "7300",
        "fuelLevel": 54,
        "positionLat": "48.137154",
        "positionLong": "11.576124"
      }
     ]
    }

----
I used Postman for that:

Authentication:
![](https://github.com/nadjbabidaniel/BasicAuthenticationWEBAPI/blob/master/Image1.png)


Body request:
![](https://github.com/nadjbabidaniel/BasicAuthenticationWEBAPI/blob/master/Image2.png)
