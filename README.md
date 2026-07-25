# Kumeler_WF - Küme Hesaplama Uygulaması

A Windows Forms application for calculating mathematical set properties and subset counts.

## 📋 Overview

**Kumeler_WF** (Sets in Turkish) is a C# Windows Forms application designed to help users calculate various properties of mathematical sets, including:

- Total number of subsets
- Proper subsets
- Subsets with specific element counts (2, 3, 4, 5, 6, 7 elements)
- Subsets with at least/at most a certain number of elements
- Finding the number of elements given subset counts

## 🚀 Features

### Set Operations
- **Alt Küme (Subset)**: Calculate total number of subsets (2^n)
- **Öz Alt Küme (Proper Subset)**: Calculate proper subsets (2^n - 1)
- **İki Elemanlı**: Number of 2-element subsets C(n,2)
- **Üç Elemanlı**: Number of 3-element subsets C(n,3)
- **Dört/Beş/Altı/Yedi Elemanlı**: Number of subsets with 4-7 elements
- **En Az X Elemanlı**: Subsets with at least X elements
- **En Çok X Elemanlı**: Subsets with at most X elements

### Special Features
- Displays all 2-element subsets visually
- "Gıcık Eleman" mode for advanced calculations
- Input validation and help tooltips
- Distinct element counting (duplicates are automatically removed)

## 🛠️ Requirements

- **Framework**: .NET Framework (Windows Forms)
- **IDE**: Visual Studio 2015 or later
- **OS**: Windows

## 📁 Project Structure

```
Kumeler_WF/
├── Program.cs              # Application entry point
├── Form1.cs                # Main form UI and event handlers
├── Form1.Designer.cs       # Auto-generated form designer code
├── Kume.cs                 # Core set calculation logic
├── App.config              # Application configuration
├── packages.config         # NuGet package references
└── Properties/             # Assembly info and resources
    ├── AssemblyInfo.cs
    ├── Resources.resx
    └── Settings.settings
```

## 🔧 Installation

1. Clone or download the repository
2. Open `Kumeler_WF.sln` in Visual Studio
3. Build the solution (Ctrl+Shift+B)
4. Run the application (F5)

## 📖 Usage

1. **Enter Set Elements**: Input set elements separated by commas in the text box (e.g., `a,b,c,d`)
2. **Select Operation**: Choose the desired calculation from the dropdown menu
3. **Calculate**: Click the button to see the result
4. **View Subsets**: All 2-element subsets are displayed in the rich text box

### Example

For a set A = {a, b, c, d}:
- Total subsets: 2^4 = 16
- Proper subsets: 2^4 - 1 = 15
- 2-element subsets: C(4,2) = 6
- Displayed: {a,b} {a,c} {a,d} {b,c} {b,d} {c,d}

## 🧮 Mathematical Formulas Used

| Operation | Formula | Description |
|-----------|---------|-------------|
| Alt Küme | 2^n | Total subsets |
| Öz Alt Küme | 2^n - 1 | Proper subsets |
| k-Elemanlı | C(n,k) = n!/(k!(n-k)!) | k-element subsets |
| En Az k | 2^n - ΣC(n,i) for i<k | At least k elements |
| En Çok k | ΣC(n,i) for i≤k | At most k elements |

## 👨‍💻 Code Structure

### Kume Class
The `Kume` class in `Kume.cs` provides the core mathematical operations:

```csharp
public class Kume
{
    public string KumeAd { get; set; }
    public List<object> KumeElemanlari { get; set; }
    
    public double AltKume(int n)           // 2^n
    public double OzAltKume(int n)         // 2^n - 1
    public double Kombinasyon(int n, int k) // C(n,k)
    // ... and more
}
```

### Form1 Class
Handles UI interactions and displays results.

## 📝 Notes

- Elements are automatically deduplicated using LINQ's `Distinct()` method
- The application uses Turkish language for UI elements
- Help tooltips are available for user guidance

## 📄 License

This project is provided as-is for educational purposes.

## 🤝 Contributing

Feel free to submit issues and enhancement requests!
