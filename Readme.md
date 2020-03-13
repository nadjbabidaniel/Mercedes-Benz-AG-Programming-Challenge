swagger: “2.0”
----

Rest API needs to be triggered with get http request: http://localhost:54728/v1/Trips/

Authentication is required with next credentials:

    | UserName:  | Password: |    
    | MaleUser   |  123456   |
    | FemaleUser |  abcdef   |

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

Expected object to be returned is VehiclePushAnalysis:

    {
    "Vin": "WDD1671591Z000999",
    "Departure": "Stuttgart",
    "Destination": "Munich",
    "RefuelStops": [
        {
            "StartTimestamp": 1559137020,
            "EndTimestamp": 1559137020,
            "PositionLat": 48.1371536,
            "PositionLong": 11.5761242
        }
    ],
    "Consumption": 2.0,
    "Breaks": [
        {
            "StartTimestamp": 1559137020,
            "EndTimestamp": 1559137020,
            "PositionLat": 48.77199,
            "PositionLong": 9.172787
        }
    ]
    }

Used external service to determine the city name for departure and destination is [Bing Maps][id/name] 

[id/name]: https://www.bingmapsportal.com/





