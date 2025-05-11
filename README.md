# Horror Game :: Patterns practice

[![License](https://img.shields.io/badge/license-MIT-blue.svg?style=flat-square)](https://github.com/yourusername/your-repo/blob/main/LICENSE)
[![Unity Version](https://img.shields.io/badge/unity-2022.2.15f1-blue.svg?style=flat-square&logo=unity)](https://unity.com/releases/editor/whats-new/2022.2.15)

> A simple **3D horror game**. You have to collect all the keys on the map before the **Evil Pumpkin** catches you

> This education project demonstrates the implementation of **Model-View-Presenter (MVP)** architectural pattern along with **Composite Root** in **Unity**

## Controls
- **WASD** (Movement)
- **Mouse** (Camera)

## Code structure

```
Scripts/
├── CompositeRoot/ - Composition root that wires all components together
├── Input/ - Input handling system
├── Model/ - Game data and business logic (pure classes)
├── System/ - Core systems and services
└── View/ - Presentation layer (Unity GameObjects and UI)
```

## Key Patterns Used

### Model-View-Presenter (MVP)

In this project:
- **Model**: Contains game data and business logic (domain layer)
- **View**: Handles visual representation and user input (presentation layer)
- **Presenter**: Mediates between Model and View (application logic layer)

### Composite Root

The Composite Root pattern is used to:
- Centralize object composition
- Manage dependencies between components
- Initialize the entire object graph in one place

## How It Works

1. **Initialization**:
   - The `CompositeRoot` script creates and wires all components together
   - It resolves dependencies between systems, models, and presenters

2. **Data Flow**:
   - User input is captured by the `Input` system
   - Input events are processed by presenters
   - Presenters update the Model and notify the View
   - View reflects the current state from the Model
