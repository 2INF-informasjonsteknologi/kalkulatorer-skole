def main():
    print("Velkommen til det enkle kalkulatorprogrammet!")

    # Meny for brukeren
    print("\nHva vil du gjøre?:")
    print("1. Addisjon")
    print("2. Subtraksjon")
    print("3. Multiplikasjon")
    print("4. Divisjon")

    choice = input("Skriv inn valget ditt (1/2/3/4): ")


    # Input to heltall fra brukeren
    num1 = int(input("Skriv inn det første heltallet: "))
    num2 = int(input("Skriv inn det andre heltallet: "))

    
    

    if choice == '1':
        print("Resultatet av addisjonen er:", num1 + num2)
    elif choice == '2':
        print("Resultatet av subtraksjonen er:", num1 - num2)
    elif choice == '3':
        print("Resultatet av multiplikasjonen er:", num1 * num2)
    elif choice == '4':
        if num2 != 0:
            print("Resultatet av divisjonen er:", num1 / num2)
        else:
            print("Kan ikke dele på null!")
    else:
        print("Ugyldig valg")


if __name__ == "__main__":
    main()
