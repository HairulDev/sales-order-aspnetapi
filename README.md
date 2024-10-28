# Getting Started

Follow the instructions below to set up and run the project on your local machine.

### Setup Instructions

1. **Environment Variables**: Open file db.sql then paste in your database management or paste in this query

   ```plaintext
  CREATE TABLE SalesOrder (
    id_order NVARCHAR(50) PRIMARY KEY,
    number_order NVARCHAR(50) NOT NULL,
    date DATE NOT NULL,
    customer NVARCHAR(100),
    address NVARCHAR(200)
);
CREATE TABLE ItemOrder (
    id_item NVARCHAR(50) NOT NULL,
    id_order NVARCHAR(50) NOT NULL,
    item_name NVARCHAR(100),
    qty INT NOT NULL,
    price DECIMAL(18, 2) NOT NULL,
    total AS (qty * price) PERSISTED,
    FOREIGN KEY (id_order) REFERENCES SalesOrder(id_order)
);
     ```
     
2. **Start Project**

   - Install project dependencies using Manage NuGet Packages
    ```bash
    Microsoft.Data.SqlClient
    ```
    - Start the project
    ```bash
    Dapper
    ```