<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <!-- 
        The [event] argument is a auto-created variable by the javascript and it reference the the current event[submit]
     -->
    <form action="./result.php" method="get" onsubmit="check(event)">
        <input type="text" name="query" id="searchField">
        <button type="submit">Search</button>
    </form>

    <script>
        // Declare variables
        let field = document.querySelector("#searchField")
        // When search button clicked
        function check(e) {
            if (field.value == "") {
                alert(0)
                // Stop the event
                e.preventDefault()
            } else {
                return true
            }
        }
    </script>
</body>

</html>