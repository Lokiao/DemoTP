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

##### AddFeature

A car can have some features, we can also add some of them.

Willy the garagist wants to add new personalized features to this car.
That's the point of this function.

***Prototype***

![img_8.png](img_8.png)

##### RemoveFeature

The car is too heavy because of all of those features.

Willy the garagist wants to remove a feature from this car.
Make a function to be able to remove one feature.

***Prototype***

![img_9.png](img_9.png)

#### Gasoline.cs

The class representing a gasoline car. Child of Car class.

##### Constructor

![img_1.png](img_1.png)

##### ToString

***Prototype***

![img_2.png](img_2.png)

***Code Example***

![img_12.png](img_12.png)
![img_13.png](img_13.png)

#### Electrical.cs

The class representing an electrical car. Child of Car class.

##### Constructor

![img_3.png](img_3.png)

##### ToString

***Prototype***

![img_2.png](img_2.png)

***Code Example***

![img_10.png](img_10.png)
![img_11.png](img_11.png)

#### Garage.cs

The class representing a garage, could be Willy's.
Inherits of the interface IGarage.

***Prototype***

![img_4.png](img_4.png)

### Intermediate