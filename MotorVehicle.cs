using System;
public class MotorVehicle{
    public string make;
    public string model;
    public MotorVehicle(string make,string model)
    {
        this.make=make;
        this.model=model;
    }
    public void getStats(){
        Console.WriteLine("Make is:"+this.make);
        Console.WriteLine("Model is: "+this.model);

    }
}