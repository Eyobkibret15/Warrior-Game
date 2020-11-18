using System;
   
  class warrior
  { 
    private string user_name;
    private  string password;

  
    public virtual string  weapon() 
    {
      return  "the warrior has a weapon";
    }

    public string User_name
    {
     get{return user_name;}
     set {user_name = value;}
    }

    public string Password
    {
     get{return password;}
     set{password = value; }
    }  

   public warrior(string name,string password)
    {
    User_name = name;
    Password = password;
    }  

  }
  
