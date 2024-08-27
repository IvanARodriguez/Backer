# The Backer Project

The Backer Project is a web application designed for smart task management and streamlined workflows. The project leverages Domain Driven Design (DDD) and Clean Architecture principles to achieve the following objectives:

- **Faster Developer Onboarding:** Simplifies understanding and working with the codebase, enabling new developers to become productive quickly.
- **Scalability:** Ensures the system can grow and adapt to increased workload and complexity without compromising performance.
- **Modularity and Separation of Concerns:** Promotes maintainability by organizing the codebase into distinct, loosely coupled modules, each responsible for a specific concern.

<div style="text-align: center;">
  <img src="https://firebasestorage.googleapis.com/v0/b/backer-bb647.appspot.com/o/Untitled-2024-06-24-1621.png?alt=media&token=0a0b9f02-b613-4ffd-bab5-7d5fcc791dad" alt="Backer Project Diagram" style="width: 60%;">
</div>

## Key Technologies

- **.NET 8 with C#:** The project is built using .NET 8, with C# as the primary programming language.

## Project Structure

The solution is organized into the following folders, reflecting the principles of Clean Architecture:

```mathematica
Backer
├── Backer.Api
├── Backer.Contracts
├── Backer.Infrastructure
├── Backer.Application
└── Backer.Domain
```

### Folder Descriptions:

1. **Backer.Api:**

   - Contains the web API endpoints.
   - Serves as the entry point for client interactions.
   - References the `Application` layer.

2. **Backer.Contracts:**

   - Defines the contracts (DTOs, request/response models) used for communication between the API and clients.
   - Also references the `Application` layer.

3. **Backer.Infrastructure:**

   - Implements the infrastructure concerns, such as data access, external service integrations, and repository patterns.
   - References both the `Application` and `API` layers.

4. **Backer.Application:**

   - Contains the application logic, use cases, and service interfaces.
   - References the `Domain` layer, implementing business rules and orchestrating tasks.

5. **Backer.Domain:**
   - Defines the core domain model, including entities, value objects, and domain services.
   - Independent of other layers, ensuring that the business logic is decoupled from infrastructure and application concerns.
