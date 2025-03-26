# dotnet-api-clean-architecture-practice

short, simple, basic

https://www.youtube.com/watch?v=sBAB_EKYPYs&ab_channel=WebGentle
// good to have separate dependency files for each layer (app, domain_core, infra)


DI_dependency injection



Domain == Core
    // = Contains core classes (=DTO_data transfer object, Entities_classes for entity framework, Enums)
    // = Business logic
    // (= commands for MediatoR)

Infrastructure
    // = Contains main implementations
    // such as...
        // 1. repository implementation for injecting a database
        // 2. Db config for entity framework core
        // 3. 3rd party sth
    // = Used when implementing something that interacts with external file