using System;
public class MotorCycle:MotorVehicle{
    public bool sidebar;
    public MotorCycle(string make,string model,bool sidebar):base(make,model)
    {
        this.sidebar=sidebar;
    }
    public void getExtra(){
        Console.WriteLine("does my bike has a sidebar? "+this.sidebar);
        
    }
    public void pullWheelie(){
        Console.WriteLine(this.model+"is pulling a wheelie");
    }
}