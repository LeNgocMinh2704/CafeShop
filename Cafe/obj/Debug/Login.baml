   M S B A M L   `   `   `  ?????  ;Cafe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:CafeCafe  5   	       
Cafe.Login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Cafe     5   	   _ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5           MaterialDesignBody#???   5      $??Regular"?5	      $??13(?5
      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=?5         TextRenderingMode$
 Auto=?5        MaterialDesignPaper#???  5        MaterialDesignFont#???  5       ? Title$ 
MainWindow??5   	   $	??500??6   $	??800??6)    ? WindowStartupLocation$ CenterScreen=?5   	    ? WindowStyle$
 None=?5   	    ? 	Resources 5        BoolToVisConverter??%   &	       ?? 5   
   6'   5      .??5      ??  ?? CornerRadius$ 50??6   ._?5   
   ?  ? ColumnDefinitions 5      ?? 5      $??* ?6#   ?? 5      $
??1.5* ?6#   .+?5      ?? -   5         ??Name$ CloseButton??5      $??/Imagine/close.png??6)   $??1??6E   	 K? ZIndex$	 1??6U     imgClsoe#??[ 6?   ?? 5       ??5!      ?? 5"      
 ?? 
StartPoint$	
 0,0&?6*    ?? EndPoint$	 1,1&?6;   .??5%      ?  ? Color$ Purple??6'    ? Offset$ 0Q?66   ? 5&      $ #3AADA1??6'   $ 1Q?67   5(      ._?5+      ? .+?5,      ?? .+?5-      ?  ? Points ?    -1???@???????#4EB1B6 J? Opacity$	 0.7Q?6M   ? 5.      ' ?    ?? ?? ???? ??
?????#4EB1B66E   A? 5/      $??250 450 0 0q?6"   $??40??67   $??40??6B   ???#4EB1B66N   A? 50      $??
50 400 0 0q?6"   $??20??66   $??20??6A   ???#4EB1B66M   51      ?? 52      $??Center=?6!   $	??312??6<   .+?53      ?? $??Beverage Shop Management??6$     	titleText#??[ 6D   $	??109??6g   $
??Wrap=?6t   ?? 54      $C??=Enter your personal info and create new account to connect us??6$     
normalText#??[ 6i   $	 0.8Q?6?   $??20 30q?6?   ?? 55      $??Sign Up??6!    
 button#??[ 63   $??50??6S   56      57      58      ?? 5;      -   5        ???#ffffff$??1??5;   *   $ 	0 10 10 0??6:   $??Center=?6S   $	??424??6?   ._?5<      ?? .+?5=      ?? $??Sign in to App??6    #??[ 66   ???#3Ab19B6Y   ?? 5?       ?? Orientation$ 
Horizontal=?6!   $
??0 20q?6:   $??Center=?6H   .+?5@      ??   buttonCircle#??[ 6!   .??5A      ?? $??imagine/google.png??6$   5B      ?? 5C      #??[ 6!   .??5D      ?? $??imagine/facebook.png??6$   5E      ?? 5F      #??[ 6!   .??5G      ?? $??imagine/linkedin.png??6$   5H      5J      ?? 5K      $??Or using your account??6    #??[ 6=   
???iii?6a   ?? 5M      ???#acb0af$??0q?63   $
??70 7q?6G   $ 5??6U   ._?5N      ? .+?5T      ?? -   5         ??Name$ txtUsername??5T   &    !	 MaterialDesignOutlinedTextBox#??[	 5U   &   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Username??5V   &      
HelperText$ Username cannot be empty??5W   )   $??5q?6i   .??6t   5Y      5^      5`      ?? 5a      ???#acb0af$??0q?63   $
??70 7q?6G   $ 5??6U   ._?5h      G? -   5         G?Name$ txtPassword??5h   *    %
 !MaterialDesignOutlinedPasswordBox#??[
 5i   *   $ 	Password ??5j   *   $ Password cannot be empty??5k   *   $??5q?5m   *   0  *MaterialDesignThemes.Wpf.PasswordBoxAssist   Password 5l   *   ??  ?? Path$ Password2Validated? ?? Mode$ TwoWay=? ?? UpdateSourceTrigger$ PropertyChanged=? ?? ValidatesOnExceptions . 5m   *   5t      ?? 5u      -   5         ??Name$ CBRoles??5u      $ Please select roles??5w      $??10q?68   $	??335??6D   5z      ?? 5|      -   5        $??Sign In??5|        Loginbutton#??[ 6D   5}      5?      5?      5?      5?      