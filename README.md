# Ruletka
> Prosty symulator gry w ruletkę zbudowany w Windows Forms w C#.

## Spis treści
* [Informacje ogólne](#informacje-ogólne)
* [Używane technologie](#używane-technologie)
* [Funkcje](#funkcje)
* [Konfiguracja](#konfiguracja)
  
## Informacje ogólne
- **Problem Solved**: Provides a virtual casino experience for users to practice roulette strategies without financial risk.
- **Purpose**: Designed as an educational/entertainment tool to demonstrate Windows Forms development and game logic.
- **Motivation**: Created to explore C# GUI programming, event handling, and randomization techniques.

## Używane technologie
- **C#** (.NET Framework)
- **Windows Forms** 
- **Visual Studio** 

## Funkcje
- **Typy zakładów**:
- Kolor (czerwony/czarny/zielony)
- Parzysty/nieparzysty
- Konkretna liczba (0-36)
- Dziesiątki (1-12, 13-24, 25-36)
- **Dynamiczny interfejs użytkownika**:
- Przełączanie motywów (klasyczny/ciemny/neonowy)
- Panele specyficzne dla typu zakładu
- **Śledzenie statystyk**:
- Licznik wygranych/przegranych
- Historia ostatnich 10 wyników
- **Zarządzanie saldem**:
- Saldo początkowe: 1000 USD
- Automatyczne wyłączenie przy zerowym saldzie

## Konfiguracja 
**Wymagania**:
- .NET Framework 4.7.2 lub nowszy
- Visual Studio 2019 (opcjonalnie do edycji)
   **Instalacja**:
   ```bash
   git clone https://github.com/Mordorlen/roulette-game.git
