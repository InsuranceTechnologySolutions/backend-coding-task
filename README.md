# Technical interview

## Programming task
Create the backend for a multi-tier application for Insurance Claims Handling.
The use case is to maintain a list of insurance claims. The user should be able to create, delete and read claims.

## Prerequisite
Your favourite IDE to code in C# 😊

**Optional:** You need an Azure Subscription. 

You can demo this API by hosting it in Azure. If that is not an option for you, you can run the demo having a locally running instance.

If you select to use a different cloud provider, that is fine for us. 

## What to do?
Download this repository and create a new github/gitlab/Azure repo which will contains your changes. You cannot fork this (our) repository or commit changes to it. 

### Task 1
The codebase is messy, the controller has too much responsibility. Introduce proper layering within the codebase. Adhere to the SOLID principles. 

### Task 2
As you can see, the API supports some basic REST operations. But validation is missing. The basic rules are:

* Claims with damageCost exceeding 100.000 cannot be created.
* Validate year, it can't be in the future or more than 10 years back. 

### Task 3
Auditing. There are some TODO statements related to Auditing in the codebase and an Azure Function has been created to handle the Audit messages. Please complete this setup, make sure that all the Audit messages are persisted in the database. 



