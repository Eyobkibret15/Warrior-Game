class archer : warrior 
{ 
 public archer(string name,string password):base(name,password){}
 public string second_weapon = "axe";

 public override   string weapon()
 { 
   return  "bow";
  }
  
}