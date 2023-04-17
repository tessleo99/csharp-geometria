// See https://aka.ms/new-console-template for more information

using Geometria;

Console.Write("Inserisci la base del rettangolo in cm: ");
float baseRettangoloUser = float.Parse(Console.ReadLine());

Console.Write("Inserisci l'altezza del rettangolo in cm: ");
float altezzaRettangoloUser = float.Parse(Console.ReadLine());

Rettangolo rettangolo1 = new Rettangolo(baseRettangoloUser, altezzaRettangoloUser);

rettangolo1.StampaRettangolo();

rettangolo1.DisegnaRettangolo();