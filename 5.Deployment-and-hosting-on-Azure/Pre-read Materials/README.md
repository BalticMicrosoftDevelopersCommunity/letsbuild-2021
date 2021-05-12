While the materials have been grouped under different heading the process of deploying and preparing enviornment where to deploy is very interlinked, especially if we think about the trend of DevOps. Because of this there will be overlap of the topics in the sources.

# Deployment
Deployment is the process by witch your application get's to the location where it will be hosted.
Can be done either from development environment (Publishing from Visual studio)

https://docs.microsoft.com/en-us/dotnet/architecture/devops-for-aspnet-developers/deploying-to-app-service?view=aspnetcore-5.0


Or from build environment
* Azure DevOps 
https://docs.microsoft.com/en-us/dotnet/architecture/devops-for-aspnet-developers/cicd?view=aspnetcore-5.0

* (alternatively) GitHub Actions
https://docs.microsoft.com/en-us/dotnet/architecture/devops-for-aspnet-developers/actions-index?view=aspnetcore-5.0

# Hosting
Locating and maintaining application in environment from witch it can be accessed by users/testers/consumers. 

Web app:
First steps: https://docs.microsoft.com/en-us/azure/app-service/quickstart-dotnetcore?tabs=netcore31&pivots=development-environment-vs

Setting up web app + db
https://docs.microsoft.com/en-us/azure/app-service/tutorial-dotnetcore-sqldb-app?pivots=platform-linux


Database:
https://docs.microsoft.com/en-us/azure/azure-sql/database/single-database-create-quickstart?tabs=azure-portal

Deployment slots & best practices:
https://docs.microsoft.com/en-us/azure/app-service/deploy-best-practices


Static web-apps in Azure:
https://www.youtube.com/watch?v=lqvYAI74w64


Setting up things through command line or web ui can be tiresome. ARM templates is one way how to automate by describing resources that are needed and letting Azure figure out how and in what sequence to set up.
https://docs.microsoft.com/en-us/azure/app-service/quickstart-arm-template?pivots=platform-linux
