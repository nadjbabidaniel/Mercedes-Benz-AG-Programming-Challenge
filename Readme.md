swagger: “2.0”
----

Rest API needs to be triggered with GET HTTP request: http://localhost:54728/v1/Trips/

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

___________________________________________________________________________________________________________________________________

info:
  description: |
    - Implement the specified REST Endpoint
    - Protect the API with BasicAuth
    - Use Docker to run your application
    - Use one of the following languages&#58; Go, Java, Python, C++
    - Automate the infrastructure rollout
    - Use an external service to determine the city name for depature and destination
    - Upload your solution to a private GitHub repository
    - Provide a link to the secured hosted instance of your solution
    - Provide the following files together with your code&#58;
      * Dockerfile
      * Build-Script
      * Deployment-Script
      * Kubernetes deployment YAML (if Kubernetes is used)
      * Infrastructure automation scripts
      * README.md with documentation how to deploy the infrastructure and the application
  version: "1.0.0"
  title: "Mercedes-Benz AG Programming Challenge"
basePath: "/v1"
tags:
- name: "Vehicle Trip Analyzer"




