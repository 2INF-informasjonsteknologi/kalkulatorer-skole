const readline = require("readline");

function main() {
  console.log("Velkommen til det enkle kalkulatorprogrammet!");

  const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout,
  });

  console.log("\nVelg en av følgende operasjoner:");
  console.log("1. Addisjon");
  console.log("2. Subtraksjon");
  console.log("3. Multiplikasjon");
  console.log("4. Divisjon");

  rl.question("Skriv inn valget ditt (1/2/3/4): ", (choice) => {
    rl.question("Skriv inn det første heltallet: ", (num1) => {
      rl.question("Skriv inn det andre heltallet: ", (num2) => {
        num1 = parseInt(num1);
        num2 = parseInt(num2);

        switch (choice) {
          case "1":
            console.log("Resultatet av addisjonen er:", num1 + num2);
            break;
          case "2":
            console.log("Resultatet av subtraksjonen er:", num1 - num2);
            break;
          case "3":
            console.log("Resultatet av multiplikasjonen er:", num1 * num2);
            break;
          case "4":
            if (num2 !== 0) {
              console.log("Resultatet av divisjonen er:", num1 / num2);
            } else {
              console.log("Kan ikke dele på null!");
            }
            break;
          default:
            console.log("Ugyldig valg");
            break;
        }

        rl.close();
      });
    });
  });
}

main();
