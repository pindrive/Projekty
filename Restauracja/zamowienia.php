<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="web_styles.css">
    <title> Restauracja </title>
</head>
<body>
    <aside>
        <h1> Dodaj zamówienie: </h1>
        <form action="zamowienia.php" method="post">
            <!-- Formularz dodawania zamówienia -->
            <label for="stolik"> Stolik: </label> <br> <br>
            <select name="stolik" id="stolik">
                <option value="1"> 1 </option>
                <option value="2"> 2 </option>
                <option value="3"> 3 </option>
                <option value="4"> 4 </option>
                <option value="5"> 5 </option>
                <option value="6"> 6 </option>
                <option value="7"> 7 </option>
                <option value="8"> 8 </option>
                <option value="9"> 9 </option>
                <option value="10"> 10 </option>
                <option value="11"> 11 </option>
                <option value="12"> 12 </option>
            </select> <br> <br>
            <label for="zamowienie"> Zamówienie: </label> <br> <br>
            <input type="text" name="zamowienie" id="zamowienie"> <br> <br> 
            <label for="kwota"> Kwota: </label> <br> <br>
            <input type="number" name="kwota" id="kwota"> <br> <br> 
            <button type="submit" value="btn_add" name="btn_add"> Dodaj </button> 
            <button type="reset"> Wyczyść </button> <br> <br>

            <!-- Formularz usuwania zamówienia -->
            <form action="zamowienia.php" method="post">
            <button type="submit" value="btn_delete" name="btn_delete"> Usuń </button>
            <select name="stolik_del" id="stolik_del">
                    <option value="1"> 1 </option>
                    <option value="2"> 2 </option>
                    <option value="3"> 3 </option>
                    <option value="4"> 4 </option>
                    <option value="5"> 5 </option>
                    <option value="6"> 6 </option>
                    <option value="7"> 7 </option>
                    <option value="8"> 8 </option>
                    <option value="9"> 9 </option>
                    <option value="10"> 10 </option>
                    <option value="11"> 11 </option>
                    <option value="12"> 12 </option>
                </select>
            </form>
            <!-- Dodawanie zamówienia -->
            <?php 
                if (!empty($_POST['zamowienie']) && !empty($_POST['kwota']) && $_POST['kwota'] >= 5)
                {
                    if (isset($_POST['btn_add']))
                    {
                        include 'add.php';
                    }
                }
            ?>
        </form>
    </aside>
    <main>
        <h1> Zamówienia </h1>
        <!-- Wyświetlanie zamówień -->
        <?php 
            require('show.php');
        ?>
        <!-- Usuwanie zamówień -->
        <?php
            if (isset($_POST['btn_delete']))
            {
                include 'delete.php';
            }
        ?>
    </main>
</body>
</html>