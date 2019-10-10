using System;
public class Car:MotorVehicle{
    public bool isConvertible;
    public Car(string make,string model,bool isConvertible):base(make,model)
    {
        this.isConvertible=isConvertible;
    }
    public void GetExtra(){
        Console.WriteLine("Is my car convertible? "+this.isConvertible);
    }
    public void Reverse(){
        Console.WriteLine(this.model+" is reveresing");
    }


}