///15 Best Coding Practices Includes:


///<summary>
///Proper Naming Conventions
///proper naming conventions such as Paschal, camel case or Hungarian case convention should be adopted
///</summary>
///Good Approach
String UserInput = "10";
///Bad Approach
String UI = "10";


///<summary>
///Proper Code Indentation
///Good code indentation makes code easier to read
///</summary>
///Good approach
for(int i = 0; i <= 5; i++ ){
    if(i == 3){
        Console.WriteLine(i);
    }
    else{
        Console.WriteLine("Not equal to 3");
    }
}
///Bad Approach
for(int i = 0; i <= 5; i++ )
{if(i == 3){Console.WriteLine(i);}
else{Console.WriteLine("Not equal to 3");}
}


///<summary>
///proper code comments
///make code very readable so as not to need commemts but if there's need to have comments, do not write comments for every line of code
///<summary>
///good approach
///my comment goes here...
///bad approach
/*
/* commemt
/* goes
/* here...
*/


///<summary>
///Avoid writing long functions
 ///If method has more than 20 lines of code, you must consider re factoring into separate  methods.
 ///</summary>
 ///Good Approach
  static DateTime ConvertDate(string DateParameter)
            {
                DateTime convertToDate = DateTime.Parse(dateParameter);
                DateTime newDate = convertToDate.AddDays(7);
                Console.WriteLine(newDate);
                return newDate;
            }
///Bad Approach: More than 20 lines of function codes


///<summary>
///Avoid writing long class files
///If the class file has more than 500 line of code, you must create partial class which combines code into single unit after compilation
///</summary>
///Good Approach
 public static class Date
    {
        internal static void DateAfterWeek()
        {
            Console.WriteLine("Enter Date: ");
            string input = Console.ReadLine();

           static DateTime ConvertDate(string dateParameter)
            {
                DateTime convertToDate = DateTime.Parse(dateParameter);
                DateTime newDate = convertToDate.AddDays(7);
                Console.WriteLine(newDate);
                return newDate;
            }
            ConvertDate(input);
        }
    }
///Bad approach: more than 500 lines of code


///<summary>
///Add a White space around operators
///</summary>
///Good approach
for(int i = 0; i <= 5; i++ ){
    if(i == 3){
        Console.WriteLine(i);
    }
    else{
        Console.WriteLine("Not equal to 3");
    }
}
///Bad approach
for(int i=0; i<=5; i++){
    if(i==3){
        Console.WriteLine(i);
    }
    else{
        Console.WriteLine("Not equal to 3");
    }
}


///<summary>
/// Method name should have meaningful name
///</summary>
///good Approach
public void CapitalLetterCheck(){

} 
///Bad approach
public void check(){

}



///<summary>
///Avoid combining multiple functionalities into single function or method
///</summary>
///Good Approach
public void CapitalLetterCheck(CapitalLetter SmallLetter){

} 
public void CheckCapitalLetters(CapitalLetter SmallLetter){

}
///Bad approach
public void Check(CapitalLetter SmallLetter){
    if (CapitalLetter == 'A'){

    }
    else{

    }
}



///<summary>
///While comparing string, convert string variables into Upper or Lower case 
///</summary>
///Good approach
if (UserName.ToLower() == "chinenye") { 

}
if (UserName.ToUpper() == “CHINENYE”) { 

}
///Bad approach
if (UserName == "Chinenye" ){

}


///<summary>
///Avoid using "" for empty string, instead use String.Empty
///</summary>
///good approach
if (UserName == String.Empty) {

 }
 ///Bad approach
 if (UserName == ""){

 }


///<summary>
///Avoid accessing objects and complex objects without doing null check
///</summary>
///good approach
public Contact GetMailDetails(email email)
{
    if (email != null && email.Contact != null)
    {
        return email.Contact;
    }
}
///Bad approach
public Contact GetMailDetails(email email)
{
    return email.Contact;
}


///<summary>
///Error messages should be self explanatory and direct users on the next step
///good approach
“Username or Password is incorrect. Please enter correct username and password." 
///Bad approach 
“Login Error”  


///<summary>
///Avoid passing more than 2 parameters to a function
///Good Approach
 public void result(userName passWord) { 

 }
///Bad approach
public void result(string userName, string passWord, string id, string phoneNumber) { 

}


///<summary>
///Simplify object creation using object initializers
///good approach
var user = new User
{
    FirstName = “Chinenye”,
    LastName = “Okeke”,
    Age = 22,
    SkinColor = "dark"
};
//Bad approach
var user= new User();
    user.FirstName = “Chinenye”,
    user.LastName = “Okeke”,
    user.Age = 22,
    user.SkinColor = "dark";



///<summary>
///Use StringBuilder class instead of string when you have to mainpulate strings
///Good approach
StringBuilder username = new StringBuilder("John");

///Bad approach
string username;
username = "John";
