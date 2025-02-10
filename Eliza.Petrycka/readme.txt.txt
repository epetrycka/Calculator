# Simple Math Operations Processor

## 📌 Opis
To proste oprogramowanie w .NET 6.0, które wykonuje podstawowe operacje matematyczne na podstawie danych wejściowych dostarczonych w formacie JSON. Obsługiwane operacje to:
- **Dodawanie** (`add`)
- **Odejmowanie** (`sub`)
- **Mnożenie** (`mul`)
- **Pierwiastek kwadratowy** (`sqrt`)

Dla każdej operacji wyniki są zapisywane w pliku `output.txt`, posortowane rosnąco.

---

## 🛠 Wymagania
- **.NET 6.0** (lub nowszy)
- Plik wejściowy `input.json` w odpowiednim formacie

---

## 📥 Struktura pliku wejściowego (`input.json`)
Plik powinien zawierać tablicę obiektów JSON, z których każdy opisuje pojedynczą operację matematyczną.

### Przykładowa zawartość `input.json`:
```json
[
  { "operator": "add", "value1": 5, "value2": 3 },
  { "operator": "sub", "value1": 10, "value2": 4 },
  { "operator": "mul", "value1": 6, "value2": 7 },
  { "operator": "sqrt", "value1": 16 }
]
```

---

## ⚙️ Jak uruchomić?
1. **Sklonuj repozytorium** (jeśli znajduje się na GitHubie):
   ```sh
   git clone https://github.com/user/repo.git
   cd repo
   ```

2. **Upewnij się, że masz .NET 6.0**:
   ```sh
   dotnet --version
   ```
   Jeśli nie masz, pobierz [stąd](https://dotnet.microsoft.com/en-us/download/dotnet/6.0).

3. **Uruchom aplikację**:
   ```sh
   dotnet run
   ```

---

## 📄 Obsługa błędów
- Jeśli w pliku JSON znajdzie się **nieznany operator** (nie `add`, `sub`, `mul`, `sqrt`), obiekt zostanie pominięty.
- Jeśli `value1` lub `value2` nie zostaną podane, domyślnie:
  - `value1` → `0`
  - `value2` → `0` (dla `add`, `sub`), `1` (dla `mul`), brak (`sqrt` nie wymaga `value2`).

---

## 📤 Wynik
- Wyniki są zapisywane w `output.txt`.
- Są **posortowane rosnąco** na podstawie wartości obliczeń.

### Przykładowa zawartość `output.txt`:
```
obj3: 0
obj2: 2
obj4: 6
obj1: 42
```

---

## 🛠 Autor
Projekt stworzony w ramach **SolarWinds Internship**. 🚀