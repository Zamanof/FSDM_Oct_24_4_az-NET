// regular expressions
using System.Text.RegularExpressions;

string password = "pasSwo7rds";
string email = "salam.qadirzade@gmail.gm";

#region classic way
//List<bool> criteries = [false, false, false];
//if(password.Length < 8) Console.WriteLine("Shifre 8 simvoldan chox olmalidir");
//else
//{
//	for (int i = 0; i < password.Length; i++)
//	{
//		if (password[i] >= 'A' && password[i] <= 'Z') criteries[0] = true;
//		if (password[i] >= 'a' && password[i] <= 'z') criteries[1] = true;
//		if (password[i] >= '0' && password[i] <= '9') criteries[2] = true;
//	}
//	if(criteries.All(x=> x)) Console.WriteLine("Correct password");
//	else Console.WriteLine("Incorrect password");
//}

//if (password.Any(x => x >='A' && x<= 'Z')) criteries[0] = true;
//if (password.Any(x => x >='a' && x<= 'z')) criteries[1] = true;
//if (password.Any(x => x >='0' && x<= '9')) criteries[2] = true;
//if (criteries.All(x => x)) Console.WriteLine("Correct password");
//else Console.WriteLine("Incorrect password");

#endregion

#region Regular Expression
/*
    RegEx -  Regular Expression
.               - istenilen bir simvol
\w              - istenilen herf-reqem simvol
\W              - istenilen herf-reqem olmayan simvol
\s              - istenilen boshluq simvol
\S              - istenilen boshluq olmayan simvol
\d              - istenilen onluq reqem simvol
\D              - istenilen onluq reqem olmayan simvol
[abc]           - moterizede gosterilen simvollardan her hansi biri
[^abc]          - moterizede gosterilen simvollardan hech biri
[a-n]           - moterizede gosterilen simvol araliqindan her hansi biri
[^a-n]          - moterizede gosterilen simvol araliqindan hech biri

*               - shablon 0 ve ya daha chox defe tekrarlanir
+               - shablon 1 ve ya daha chox defe tekrarlanir
?               - shablon 0 ve ya 1 defe tekrarlanir
{n,m}           - shablon n defeden az olmayaraq ve m defeden chox olmayaraq tekrarlanir
{n,}            - shablon n defeden az olmayaraq tekrarlanir
{n}             - shablon n tekrarlanir
^               - metnin evveli
$               - metnin sonu
 
*/

//string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$";
//Regex regex = new Regex(passwordPattern);
//Console.WriteLine(regex.IsMatch(password));
//Regex mailPattern = new(@"^[\w\.-]+@[\w\.-]+\.\w{2,}$");
//Console.WriteLine(mailPattern.IsMatch(email));

#endregion
