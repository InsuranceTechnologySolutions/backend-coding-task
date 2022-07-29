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

[MS SQL Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) - scroll down a bit, right download link.

[Azure Cosmos DB Emulator](https://docs.microsoft.com/en-us/azure/cosmos-db/local-emulator?tabs=ssl-netstd21)


## What to do?
Download this repository and create a new github/gitlab/Azure repo which will contains your changes. You cannot fork this (our) repository or commit changes to it. 

**(We should set this repository up as a template repository and test this github feature)**

### Task 1
The codebase is messy:
* The controller has too much responsibility. 
* Introduce proper layering within the codebase. 
* Documentation is missing.
* ++

Adhere to the SOLID principles.

### Task 2
As you can see, the API supports some basic REST operations. But validation is missing. The basic rules are:

* Claims with damageCost exceeding 100.000 cannot be created.
* Validate year, it can't be in the future or more than 10 years back. 

### Task 3
Auditing. The basics are there, but the execution of the DB command (INSERT & DELETE) blocks the processing of the HTTP request. How can this be improved? Look into some asynchronous patterns. It is ok to introduce an Azure managed service to help you with this (ServiceBus/EventGrid/Whatever), but that is not required. Whatever you can manage to get working which is in-memory is also ok.

### Task 4
One basic test is included, please add other (mandatory) unit tests. Note: If you start on this task first, you will find it hard to write proper tests. You should first introduce proper layering, interfaces, remove the tight couplings ++. You should then be able to mock some dependecies which will make your testing much easier. And remember, test readability is important. Look into extracting common boilerplate / arrangment code to separate fixture(s). You are free to use whatever mocking library you want.

<br><br>

#### **Disclaimer**
As you can see - a key is committed to the appsettings.json file. However, this is the common key for the Azure Cosmos Emulator, all instances uses the exact same value, so it is not a secret.



