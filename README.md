# Design Assignment 1 - Software Design for Industrial Automation

This project involves the implementation and testing of basic and composite Function Blocks in the EcoStruxure Automation Expert environment by Schneider Electric[cite: 1]. The solutions are based on the IEC 61499 standard for PLC programming[cite: 1].

**Author:** Exchange student at LTU[cite: 1].

## Implemented Function Blocks

### Basic Function Blocks

*   **`RS Latch` (and `SR Latch`)**
    A latch block where the Set (S) event sets the output to `true`, and the Reset (R) event changes it to `false`[cite: 1]. The output event is triggered only when the output state changes[cite: 1].
    
    *Internal structure (ECC):*
    ![RS/SR Latch ECC Diagram](additional_materials/E_RS_SR_ECC.png)[cite: 3]
    
    *Timing diagram:*
    ![RS Latch Timing Diagram](timing_diagrams/E_RS_timing_diagram.png)[cite: 2]

*   **`D Flip-Flop`**
    A D-type flip-flop block[cite: 1]. The algorithm checks the state of the `D` variable when the clock event (CLK) is triggered[cite: 1]. The transition condition to update the output `Q` requires a difference between the input and output values: **`CLK AND (Q <> D)`**.
    
    *Internal structure (ECC):*
    ![D Flip-Flop ECC Diagram](additional_materials/E_D_FF_ECC.png)[cite: 3]
    
    *Timing diagram:*
    ![D Flip-Flop Timing Diagram](timing_diagrams/E_D_FF_timing_diagram.png)[cite: 2]

### Composite Function Blocks

*   **`Event Train` (`E_TRAIN`)**
    Generates a specific sequence of output events after the START event is triggered[cite: 1]. The delay between events is defined by the delay time input, and the total number of events is defined by the variable `N`[cite: 1].
    
    *Internal structure (FBN):*
    ![Event Train FBN Diagram](additional_materials/E_TRAIN_FBN.png)[cite: 3]
    
    *Timing diagram:*
    ![Event Train Timing Diagram](timing_diagrams/E_TRAIN_timing_diagram.png)[cite: 2]

*   **`Event Rising Trigger` (`E_R_TRIG`)**
    Detects a state change of the input variable from `false` to `true`[cite: 1]. An output event is generated exclusively on a rising edge[cite: 1].
    
    *Internal structure (FBN):*
    ![Rising Trigger FBN Diagram](additional_materials/E_R_TRIG_FBN.png)[cite: 3]
    
    *Timing diagram:*
    ![Rising Trigger Timing Diagram](timing_diagrams/E_R_TRIG_timing_diagram.png)[cite: 2]

## Testing Methodology

A dedicated test application was created for each implemented block[cite: 1]. Their behavior was directly compared to the official, built-in blocks from the software library[cite: 1]. The tests confirmed that the created blocks behave identically to their reference counterparts[cite: 1].

## Conclusions & Known Issues

*   **Restricted Variable Names:** While designing the `E_TRAIN` block, the time variable had to be renamed from the default `DT` to `DelayTime` due to environment constraints[cite: 1].
*   **Documentation Discrepancy:** A behavioral difference was noted in the `E_TRAIN` block compared to the assignment schematics[cite: 1]. In practice, the STOP event must be triggered before the START event for the sequence to properly begin[cite: 1].
*   **Architecture Modularity:** The IEC 61499-based environment offers a significant advantage by separating algorithm logic from the target hardware platform (Distributed Systems), allowing the full structure to be designed before coupling it with physical controllers[cite: 1].

---

# Zadanie Projektowe 1 - Projektowanie Oprogramowania dla Automatyki Przemysłowej

Projekt polega na implementacji i przetestowaniu podstawowych oraz złożonych bloków funkcyjnych w środowisku EcoStruxure Automation Expert firmy Schneider Electric[cite: 1]. Rozwiązania opierają się na standardzie IEC 61499 dla programowalnych sterowników logicznych[cite: 1].

**Autor:** Student wymiany na LTU[cite: 1].

## Zaimplementowane Bloki Funkcyjne

### Podstawowe Bloki Funkcyjne (Basic Function Blocks)

*   **`RS Latch` (oraz `SR Latch`)**
    Blok przerzutnika, w którym zdarzenie Set (S) ustawia wyjście na `true`, a zdarzenie Reset (R) zmienia je na `false`[cite: 1]. Zdarzenie wyjściowe jest wyzwalane tylko przy zmianie stanu[cite: 1].
    
    *Wewnętrzna struktura (ECC):*
    ![Schemat ECC dla RS/SR Latch](additional_materials/E_RS_SR_ECC.png)[cite: 3]
    
    *Diagram czasowy:*
    ![Diagram czasowy dla RS Latch](timing_diagrams/E_RS_timing_diagram.png)[cite: 2]

*   **`D Flip-Flop`**
    Blok przerzutnika typu D[cite: 1]. Algorytm sprawdza stan zmiennej `D` w momencie wyzwolenia zdarzenia zegara (CLK)[cite: 1]. Warunkiem przejścia i aktualizacji wyjścia `Q` jest wystąpienie różnicy między wartością wejściową a wyjściową: **`CLK AND (Q <> D)`**.
    
    *Wewnętrzna struktura (ECC):*
    ![Schemat ECC dla D Flip-Flop](additional_materials/E_D_FF_ECC.png)[cite: 3]
    
    *Diagram czasowy:*
    ![Diagram czasowy dla D Flip-Flop](timing_diagrams/E_D_FF_timing_diagram.png)[cite: 2]

### Złożone Bloki Funkcyjne (Composite Function Blocks)

*   **`Event Train` (`E_TRAIN`)**
    Generuje określoną sekwencję zdarzeń wyjściowych po wyzwoleniu zdarzenia START[cite: 1]. Opóźnienie między zdarzeniami określa wejście czasowe, a liczbę wygenerowanych zdarzeń definiuje zmienna `N`[cite: 1].
    
    *Wewnętrzna struktura sieci bloków (FBN):*
    ![Schemat FBN dla Event Train](additional_materials/E_TRAIN_FBN.png)[cite: 3]
    
    *Diagram czasowy:*
    ![Diagram czasowy dla Event Train](timing_diagrams/E_TRAIN_timing_diagram.png)[cite: 2]

*   **`Event Rising Trigger` (`E_R_TRIG`)**
    Wykrywa zmianę stanu wejścia z `false` na `true`[cite: 1]. Zdarzenie wyjściowe generowane jest wyłącznie przy zboczu narastającym[cite: 1].
    
    *Wewnętrzna struktura sieci bloków (FBN):*
    ![Schemat FBN dla Rising Trigger](additional_materials/E_R_TRIG_FBN.png)[cite: 3]
    
    *Diagram czasowy:*
    ![Diagram czasowy dla Rising Trigger](timing_diagrams/E_R_TRIG_timing_diagram.png)[cite: 2]

## Metodologia Testowania

Dla każdego zaimplementowanego bloku stworzono dedykowaną aplikację testową[cite: 1]. Ich zachowanie zostało bezpośrednio porównane z oficjalnymi blokami wbudowanymi w bibliotekę oprogramowania[cite: 1]. Testy potwierdziły, że przygotowane bloki zachowują się identycznie jak ich referencyjne odpowiedniki[cite: 1].

## Wnioski i Znane Problemy (Known Issues)

*   **Zastrzeżone nazwy zmiennych:** Podczas projektowania bloku `E_TRAIN` konieczna była zmiana nazwy zmiennej czasowej z domyślnego `DT` na `DelayTime`, z uwagi na restrykcje środowiska[cite: 1].
*   **Rozbieżności z dokumentacją:** Zauważono różnicę w działaniu bloku `E_TRAIN` względem schematów z zadania[cite: 1]. W praktyce konieczne jest wyzwolenie zdarzenia STOP przed zdarzeniem START, aby sekwencja mogła się rozpocząć[cite: 1].
*   **Modułowość architektury:** Środowisko oparte na normie IEC 61499 oferuje znaczną przewagę poprzez oddzielenie logiki algorytmów od docelowej platformy sprzętowej (Distributed Systems), pozwalając na pełne zaprojektowanie struktury przed sprzęgnięciem z fizycznymi kontrolerami[cite: 1].