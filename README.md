I couldn't create an temp azure account as my credit card was already being used on another.

The steps to deploy are:
Create on azure a webapp with seq(easiest way is to import a docker container with it and then configure the appsettings with the generated link/keys
Same things for keycloack, need to create a VM on azure, install de needed packages and install keycloack(its a long process if you dont have a template or some automated text, thankfully it we do have it as noted below
Tutorial can be found here:
https://medium.com/@aravindan.acct/part-1-deploy-keycloak-on-microsoft-azure-bce3934aa8a5
once it is done, its configurations should be added to appsettings.

A sql intance should be created on azure and the connection string should be configured on appsettings.

Create redis cache on azure and configure it on appsettings

Create an api container on azure and link it to the github repository, it will generate the deploy gitaction.

Either you can run this from git with a gitaction trigger or from azure so you can update the api.


Create an webapp container on azure and deploy the frontend.
