using System;
using System.Net.Mail;
class VSum
{	//Declare private variables
	private static string inputVal;
	private static string valType;
	private static string text;
	private static double dnum;
	private static int inum;
	private static Boolean TrueOrFalse;
	private static MailAddress iEmail;
	private static DateTime iDate;
	private static char chr;
	public VSum()//Default constructor zero parammaters
	{
		//test with default values
		setInputVal("Jackson123@gmail.com");
		setValType("Jackson123@gmail.com");
		calculateValType("Jackson123@gmail.com");
	}
	public VSum(string textInput)//Constructor receiving text input
    {
			setInputVal(textInput);
			setValType(textInput);
			calculateValType(textInput);
    }
	public void setInputVal(string textIn)//set input value
    {
		inputVal = textIn;
    }
	public void setValType(string vType)//set value type
    {
		valType = vType;
    }
	public void setString(string val)//set string text
    {
		text = val;
    }

	public void setInteger(int val)//set integer
    {
		inum = val;
    }
	public void setDouble(double val)//set double
    {
		dnum = val;
    }
	public void setBoolean(Boolean tof)//set boolean
    {
		TrueOrFalse = tof;
    }
	public void setEmail(MailAddress em)//set email
    {
		iEmail = em;

    }
	public void setDate(DateTime dt)//set date
    {
		iDate = dt;
    }
	public void setChar(char c)//set char
    {
		chr = c;
    }
	public string getString()//get string text
    {
		return text;
    }
	public int getInteger()//get integer tpye
    {
		return inum;
    }
	public double getDouble()//get double type
    {
		return dnum;
    }
	public char getChar()//get char type
    {
		return chr;
    }
	public DateTime getDate()//get date type
    {
		return iDate;
    }
	public MailAddress getEmail()//get email type
    {
		return iEmail;
	}
	public Boolean getBoolean()//get boolean type
	{
		return TrueOrFalse;
	}
	public string getValType()//get value type
    {
		return valType;
    }
	public string getInputVal()//get input value
    {
		return inputVal;
    }
	public int getLength()//get length
    {
		return inputVal.Length;
    }
	public string displaySummary()//display summary of input text value types
    {
		string ret = "Input: " + getInputVal() + "\nValue type: " + valType + "\n" + "Length: " + getLength().ToString() + "\n";
		
		if (getValType() == "Character") ret += "Char: True \n";
		else ret += "Char: False \n";
		ret += "Boolean: " + getBoolean().ToString() + "\n";

		if (getEmail() is null) ret += "Email: False \n";
		else ret += "Email: True \n";

		if (getValType() == "DateTime") ret += "Date: True \n";
		else ret += "DateTime: False \n";

		return ret;
    }

	private void calculateValType(string valIn)//private function, should not be able to call this from main
    {
		//Calculate different variable types applicable towards input text
		valType = "String/Text";
		//validate if text is type character
		if (valIn.Length == 1)
		{
			var xChar = Convert.ToChar(valIn);
			setChar(xChar);
			valType = "Character";
		}
		//Validate if text is type integer
        try
        {
			int i = Convert.ToInt32(valIn);
			setValType("Integer");
        }catch(Exception ex)//not int
        {
			
        }
		//Validate if text is type double 
        try
        {
			if (valType != "Integer")
			{
				double x = Convert.ToDouble(valIn);
				setValType("Double");
			}
        }catch(Exception ex)//not double
        {
			
		}
		//Validate if text is type boolean
		try
		{
			if (valIn.ToLower() == "true" || valIn.ToLower() == "false")
			{
				setValType("Boolean");
				setBoolean(true);
			}
		}catch(Exception ex)
        {
			setBoolean(false);
		}
		//Validate if text is in date format
		try
		{
			var xEmail = new MailAddress(valIn);
			setEmail(xEmail);
			setValType("Email");
		}
		catch (Exception ex)//not email type
		{
			
		}
        //Validate if text is in date format
        try
        {
			var xDate = DateTime.Parse(valIn);
			setDate(xDate);
			setValType("DateTime");
        }catch(Exception ex)//not date type
        {
		
        }
		
	}
}
