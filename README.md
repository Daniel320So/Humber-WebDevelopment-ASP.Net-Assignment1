# README

This respository is for Assignment 1 on HTTP 5112 - ASP.Net. The student id is N01537612.

Please follow below steps to test the assignment1

## 1. Run the Server on local host
    Open the project ./Assignment1.sln in Visual Studio
	Start up the controllers in ./Assignment1/Controllers

## 2 Test Q1 - Add Ten

```bash
	curl https://localhost:44302/api/AddTen/21
    curl https://localhost:44302/api/AddTen/0
    curl https://localhost:44302/api/AddTen/-9
```

## 3 Test Q2 - Square

```bash
    curl https://localhost:44302/api/Square/2
    curl https://localhost:44302/api/Square/-2
    curl https://localhost:44302/api/Square/0
    curl https://localhost:44302/api/Square/10
```

## 4 Test Q3 - Greeting

```bash
    curl https://localhost:44302/api/Greeting
```

## 5 Test Q4 - Greeting with Number of People

```bash
    curl https://localhost:44302/api/Greeting/3
    curl https://localhost:44302/api/Greeting/0
    curl https://localhost:44302/api/Greeting/6
```

## 6 Test Q5 - Number Machine

```bash
    curl https://localhost:44302/api/NumberMachine/2
    curl https://localhost:44302/api/NumberMachine/-5
    curl https://localhost:44302/api/NumberMachine/0
    curl https://localhost:44302/api/NumberMachine/5
```

## 7 Test Q6 - Hosting Cost

```bash
    curl https://localhost:44302/api/HostingCost/0
    curl https://localhost:44302/api/HostingCost/14
    curl https://localhost:44302/api/HostingCost/15
    curl https://localhost:44302/api/HostingCost/21
    curl https://localhost:44302/api/HostingCost/28
```
