## Code Smells Solution

This solution demonstrates common **code smells** and their **refactored alternatives** in C#.
Each smell is placed under the `Smells` folder, with the corresponding cleaned-up version in the `Refactored` folder.

You can run the solution with:

    dotnet run

#### 📂 Project Structure

    CodeSmellsSolution/
    │   Program.cs
    │   CodeSmellsSolution.csproj
    │   README.md
    │
    ├── Smells/        # Code with smells
    └── Refactored/    # Cleaned-up versions


#### 🧭 Categories & Examples

**1. Bloaters**

Large or unwieldy code constructs.
- **LongMethod** – Method does too much.
- **LargeClass** – Class has too many responsibilities.
- **PrimitiveObsession** – Using primitive types instead of domain concepts.
- **LongParameterList** – Too many parameters passed to methods.
- **Data Clumps** - Groups of data that are always passed together.

**2. Object-Orientation Abusers**

Misuse of OOP features.
- **SwitchStatements** – Type checks instead of polymorphism.
- **TemporaryField** – Fields used only in certain cases.
- **RefusedBequest** – Subclass inherits methods it doesn't need.
- **AlternativeClassesWithDifferentInterfaces** – Similar classes with different interfaces.

**3. Change Preventers**

Code that resists modification.
- **DivergentChange** – One class changes for many reasons.
- **ShotgunSurgery** – One change requires edits in many places.
- **ParallelInheritanceHierarchies** – New class requires another new class elsewhere.

**4. Dispensables**

Unnecessary or redundant code.
- **Comments** – Comments explain code that should be self-explanatory.
- **DuplicateCode** – Same logic repeated in multiple places.
- **LazyClass** – Class that does almost nothing.
- **DataClass** – Class that only holds data with no behavior.
- **DeadCode** – Unused code.
- **Speculative Generality** – Code that anticipates future needs that never materialize.

**5. Couplers**

Excessive coupling between classes.
- **FeatureEnvy** – One class excessively uses another's data.
- **InappropriateIntimacy** – Classes know too much about each other's internals.
- **MessageChains** – Long chains of method calls.
- **MiddleMan** – Class delegates all work to another.
- **IncompleteLibrary** – Library that doesn't provide needed functionality.

#### 🚀 How to Use

Browse **Smells/** to see an example of a bad pattern.
Browse **Refactored/** for the improved version.
