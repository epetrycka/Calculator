## Oprogramowanie w .NET 6.0, które wykonuje operacje:
- **Dodawania** (`add`)
- **Odejmowania** (`sub`)
- **Mnożenia** (`mul`)
- **Pierwiastkowania kwadratowego** (`sqrt`)

## Obsługa błędów
- Jeśli w pliku JSON znajdzie się **nieznany operator** (nie `add`, `sub`, `mul`, `sqrt`), obiekt zostanie pominięty.
- Jeśli `value1` lub `value2` nie zostaną podane, domyślnie:
  - `value1` → `0`
  - `value2` → `0` (dla `add`, `sub`), `1` (dla `mul`), brak (`sqrt` nie wymaga `value2`).

---

## Wynik
- Wyniki są zapisywane w `output.txt`.
- Są **posortowane rosnąco** na podstawie wartości obliczeń.