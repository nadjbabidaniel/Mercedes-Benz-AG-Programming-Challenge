swagger: "2.0"
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
