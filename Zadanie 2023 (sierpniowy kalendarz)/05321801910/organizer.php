<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="styl5.css">
    <title> Sierpniowy kalendarz </title>
</head>
<body>
    <header>
        <section id="baner1">
            <h1> Organizer: SIERPIEŃ </h1>
        </section>
        <section id="baner2">
            <?php
                $id_polaczenia = mysqli_connect("localhost", "root", "", "kalendarz");

                if (isset($_POST["wydarzenie"]))
                {
                    $wpis = $_POST['wydarzenie'];
                    $zapytanie = mysqli_query($id_polaczenia, "UPDATE zadania SET wpis = '$wpis' WHERE dataZadania = '2020-08-09';");
                }

                mysqli_close($id_polaczenia);
            ?>
            <form action="organizer.php" method="post">
                <label for="wydarzenie"> Zapisz wydarzenie: </label>
                <input type="text" name="wydarzenie" id="wydarzenie">
                <input type="submit" value="OK">
            </form>
        </section>
        <section id="baner3">
            <img src="logo2.png" alt="sierpień">
        </section>
    </header>
    <main>
        <section id="glowny">
            <?php
                $id_polaczenia = mysqli_connect("localhost", "root", "", "kalendarz");

                $zapytanie = mysqli_query($id_polaczenia, "SELECT dataZadania, wpis FROM zadania WHERE miesiac = 'sierpien';");
                $rows = mysqli_fetch_row($zapytanie);

                while ($rows != "")
                {
                    echo "
                    <section id='blok_kalendarza'>
                        <h5> $rows[0] </h5>
                        <p> $rows[1] </p>
                    </section>
                    ";
                    
                    $rows = mysqli_fetch_row($zapytanie);
                }

                mysqli_close($id_polaczenia);
            ?>
        </section>
    </main>
    <footer>
        <section id="stopka">
            <p> Stronę wykonał: 05321801910 </p>
        </section>
    </footer>
</body>
</html>