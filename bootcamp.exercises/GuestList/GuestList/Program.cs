using System.Runtime.ExceptionServices;

List<string> partyGuests = new List<string>();
List<string> guestInvite = new List<string>();
bool addNewGuests;
int numberOfNewGuests;

partyGuests.Add("Norman Lear");
partyGuests.Add("Maggie Verbeeren");
partyGuests.Add("Gavin Verbeeren");
partyGuests.Add("Noreen Verbeeren");
partyGuests.Add("Aiden Verbeeren");

foreach (string partyGuest in partyGuests)
{
    Console.WriteLine($"Hi {partyGuest}! You're invited to my party.");
    Console.WriteLine($"Would you like to new guest(s), too?");
    addNewGuests = Console.ReadLine().Trim().ToLower() == "y";
    if (addNewGuests)
    {
        Console.WriteLine("How many guests would you like to add?");
        numberOfNewGuests = int.Parse(Console.ReadLine().Trim());
        guestInvite = AddGuests(numberOfNewGuests);
    } 
}

Console.WriteLine("Here is the guest list:");
foreach (string guest in guestInvite)
{
    Console.WriteLine(guest);
}
foreach (string partyGuest in partyGuests)
{
    Console.WriteLine(partyGuest);
}

List<string> AddGuests(int numberOfNewGuests)
{

    for (int i = 1; i <= numberOfNewGuests; i++)
    {
        guestInvite.Add($"GuestName {i}");
    }

    return guestInvite;
}

