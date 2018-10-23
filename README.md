# Skolprojekt


## Presentation Layer
Windows form efter KT13.
- Lägg till namn på Podcasten
- Behövs inte beskrivning av avsnitt
- Visa alla podcasts vid filtrering av kategori

## Business Logic Layer
 Timer - Async grejsemojs för att uppdatera RSS för den podcasten

## Lägg till/ta bort kategori från XML.
- Namn på kategori
- Ändra namn på Kategori => Uppdatera alla sparade => !(Kontrollera om det finns sedan innan)
- Ta bort Kategori => !(Kontrollera om används)

## Lägg till/ta bort RSS för Podcast
- HTML, namn, kategori, uppdateringsintervall (låst till anvigvna minuter).
- Ändra namn på Kategori => !(Kontrollera om det finns sedan innan)
- Ändra URL => !(Kontrollera om det finns sedan innan)

## Data Access Layer
XML för Podcast RSS

XML för kategorier
