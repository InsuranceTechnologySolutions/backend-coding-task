# Technical interview

## Programming task
Complete the backend for a multi-tier application for Insurance Claims Handling.
The use case is to maintain a list of insurance claims. The user should be able to create, delete and read claims.

## Prerequisite
Your favourite IDE to code in C# 😊

**Optional:** You need an Azure Subscription. 

You can demo this API by hosting it in Azure. If that is not an option for you, you can run the demo having a locally running instance.

If you select to use a different cloud provider, that is fine for us. 

Note: To get this template working, you need to install the Azure Cosmos DB emulator and a localDB (MS SQL Express).

[MS SQL Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) - scroll a bit down, right download link.

[Azure Cosmos DB Emulator](https://docs.microsoft.com/en-us/azure/cosmos-db/local-emulator?tabs=ssl-netstd21)


## What to do?
Download this repository and create a new github/gitlab/Azure repo which will contains your changes. You cannot fork this (our) repository or commit changes to it. 

### Task 1
The codebase is messy:
* The controller has too much responsibility. 
* Introduce proper layering within the codebase. 
* ++

Adhere to the SOLID principles.

### Task 2
As you can see, the API supports some basic REST operations. But validation is missing. The basic rules are:

* Claims with damageCost exceeding 100.000 cannot be created.
* Validate year, it can't be in the future or more than 10 years back. 

### Task 3
Auditing. The basics are there, but now the execution of the DB command (INSERT & DELETE) blocks the action. How can this be improved? Look into some asynchronous patterns. It is ok to introduce a managed service to help you with this (ServiceBus/EventGrid/Whatever), but that is not required. Whatever you can manage to get working which is in-memory is also ok.

### Task 4
Only one basic test is included, please add other (mandatory) unit tests. 


