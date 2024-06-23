# Demo TP: About Cars.

## OOP Composition & Inheritance


### Introduction

Oh, hello there. You must be the newbie that just arrived.
My name is William, but you can call me Willy, I am a garagist.

I heard you were looking for a job. Come help me out, I need someone either way.

### Easy

In this first part, let's develop the structure of our project as well as some simple and necessary functions.

#### CarFeature.cs

A simple class representing the features that a car can have.

##### Properties

A feature just has a name and a description :

> - FeatureName, a string with a public get and set
> - FeatureDescription, a string with a public get and set

##### Constructor

![img_7.png](img_7.png)

#### Car.cs

Here you need to define the Car abstract class inheriting from the IRaceable interface.

***Prototype***

![img_6.png](img_6.png)

Define all the functions asked by the IRaceable class.

##### Properties

All the cars have a lot of attributes that need to be defined :

> - LicenseNumber, a string with a public get and protected set
> - Brand, a string with a public get and protected set
> - Model, a string with a public get and protected set
> - MaxSpeed, a double with a public get and protected set
> - Acceleration, a double with a public get and protected set
> - Speed, a double with a public get and set
> - Noise, a double with a public get and set
> - Features, a list of CarFeature with a public get and set

#### Gasoline.cs

The class representing a gasoline car. Child of Car class.

##### Constructor

![img_1.png](img_1.png)

##### ToString

![img_2.png](img_2.png)

#### Electrical.cs

The class representing an electrical car. Child of Car class.

##### Constructor

![img_3.png](img_3.png)

##### ToString

![img_2.png](img_2.png)

#### Garage.cs

The class representing a garage, could be Willy's.
Inherits of the interface IGarage.

***Prototype***

![img_4.png](img_4.png)

### Intermediate