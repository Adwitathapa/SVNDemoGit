﻿using System;

public class Car
{
     int noOfWheels;
     String model;
     String engineInLiters;
	public Car()
	{
	}
    public Car(int noOfWheels, String model, String engineInLiters)
    {
        this.engineInLiters = engineInLiters;
        this.model = model;
        this. noOfWheels = noOfWheels;
    }
}
