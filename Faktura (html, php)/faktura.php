<!DOCTYPE html>
<html>
    <head>
       <title> Faktura </title>
       <meta charset="UTF-8" /> 
    </head>

     <body style ="background-color: #08826A; color: white";>

    <hr>
    <?php
    echo "Data Wystawienia: <br />";
    echo $_POST['DataW'];
    ?>

   <center>
   
   <h3> FAKTURA NR </h2> <?php echo $_POST['Nr'];
   echo "<br />";
   ?>

   </center>

   <br> 

   <p style = "font-size: 20px;"> Sprzedawca: </p> <br>
   <?php
   echo "Nip: ";
   echo $_POST['NipS'];
   echo "<br />";

   echo "Adres: ";
   echo $_POST['AdresS'];
   echo "<br />";

   echo "Nr konta: ";
   echo $_POST['NrKontaS'];
   echo "<br />";

   echo "Telefon: ";
   echo $_POST['TelS'];
   echo "<br />";

    ?>

<p style = "font-size: 20px;"> Nabywca: </p> <br>
   <?php
   echo "Nip: ";
   echo $_POST['NipN'];
   echo "<br />";

   echo "Adres: ";
   echo $_POST['AdresN'];
   echo "<br />";

   echo "Nr konta: ";
   echo $_POST['NrKontaN'];
   echo "<br />";

   echo "Telefon: ";
   echo $_POST['TelN'];
   echo "<br />";

   $cenaN = $_POST['Cena'];
   $rabat = $_POST['Rabat']; 
   $vat = $_POST['Vat'];
   $prorabat = $rabat / 100;
   $cenaporabacie = $cenaN - ($prorabat * $cenaN);
   $ilosc = $_POST['Il'];

   $wartosc_netto = $cenaporabacie * $ilosc;
   $provat = $vat / 100;
   $wartoscV = $provat * $wartosc_netto;
   $wartoscB = $wartoscV + $wartosc_netto;

    ?>

    <br> <br>

    <p> Pozycje faktury: </p>

    <table border="3">
       <tr>
          <td> Lp. </td> <td> Nazwa </td> <td> Rabat </td> <td> Ilość </td> <td> Cena netto </td> <td> Cena po rabacie </td> <td> Wartość netto </td> <td> Vat </td> <td> Wartość Vat </td> <td> Wartość brutto </td>
       </tr>
       <tr>
          <td> 1 </td> <td> <?php echo $_POST['Nazwa']; ?> </td> <td> <?php echo $_POST['Rabat']; ?> </td> <td> <?php echo $_POST['Il']; ?> </td> <td> <?php echo $_POST['Cena']; ?> </td> <td> <?php echo $cenaporabacie ?> </td> <td> <?php echo $wartosc_netto ?> </td> <td> <?php echo $_POST['Vat']; ?> </td> <td> <?php echo $wartoscV ?> </td> <td> <?php echo $wartoscB ?> </td>
       </tr>
       <tr>
          <td> 2 </td> <td> Dostawa </td> <td> 0% </td> <td> 1 </td> <td> 10 </td> <td> 10 </td> <td> 10 </td> <td> 23 </td> <td> 2,30 </td> <td> 12,30 </td>
       </tr>
    </table>

     </body>
</html>