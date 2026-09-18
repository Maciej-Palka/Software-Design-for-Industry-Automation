# Design Assignment 1 - Software Design for Industrial Automation

This project involves the implementation and testing of basic and composite Function Blocks in the EcoStruxure Automation Expert environment by Schneider Electric[cite: 1]. The solutions are based on the IEC 61499 standard for PLC programming[cite: 1].

**Author:** Maciej Pałka, exchange student at LTU[cite: 1].

## Implemented Function Blocks

The assignment required the creation of two basic and two composite function blocks[cite: 1]:

### Basic Function Blocks
*   **`RS Latch` (and `SR Latch`):** A latch block where the Set (S) event sets the output variable to `true`, and the Reset (R) event changes it to `false`[cite: 1]. The output event is triggered only when the output value changes[cite: 1]. The `SR` block operates internally on the same principle[cite: 1].
*   **`D Flip-Flop`:** A D-type flip-flop block[cite: 1]. The algorithm checks the state of the input variable `D` when the clock event (CLK) is triggered[cite: 1]. If the input value differs from the output value, the output `Q` is updated and the output event is triggered[cite: 1].

### Composite Function Blocks
*   **`Event Train` (`E_TRAIN`):** Generates a specific sequence of output events after the START event is triggered[cite: 1]. The delay between events is defined by the delay time input variable, and the total number of generated events is defined by the variable `N`[cite: 1]. A counter inside the block's network counts the generated events and stops the cycle when it equals the value `N`[cite: 1].
*   **`Event Rising Trigger` (`E_R_TRIG`):** Detects a state change of the input variable from `false` to `true`[cite: 1]. An output event is generated only if the variable changes to true after the event input is activated[cite: 1].

## Testing Methodology

A dedicated test application was created for each implemented block[cite: 1]. The behavior of the custom blocks was directly compared to the official, built-in blocks from the Schneider Electric library[cite: 1]. The tests confirmed that the created blocks behave identically to their library counterparts[cite: 1].

## Conclusions & Known Issues
*   **Restricted Variable Names:** While creating the `E_TRAIN` block, the time input variable had to be renamed from the default `DT` to `DelayTime` because the environment prohibited the use of the name `DT`[cite: 1].
*   **Documentation Discrepancy:** A difference was observed in the `E_TRAIN` block's behavior compared to the assignment diagrams[cite: 1]. In the actual environment, the STOP event must be triggered before the START event for the sequence to begin properly[cite: 1].
*   **Hardware vs. Software Architecture:** The IEC 61499-based environment offers high modularity[cite: 1]. It allows for the algorithms and program structure to be designed first, and only later mapped to physical controllers or distributed systems, which is a significant advantage over classic environments like TIA Portal[cite: 1].

---

## Source Code Snippets (Structured Text)

Below is the execution code implemented inside the Basic Function Block algorithms[cite: 1]:

**RS_LATCH / SR_LATCH Algorithms:**
```iecst
// ALGO_SET execution code
Q := TRUE;

// ALGO_RESET execution code
Q := FALSE;