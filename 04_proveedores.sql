-- 1. Crear la tabla proveedores con los campos obligatorios
CREATE TABLE proveedores (
    id_proveedor INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    RUC VARCHAR(20) NOT NULL UNIQUE,
    telefono VARCHAR(8) NOT NULL, -- Teléfono de 8 dígitos
    correo VARCHAR(100) NOT NULL
);

-- 2. Alterar la tabla productos para enlazarla con proveedores
ALTER TABLE productos 
ADD COLUMN id_proveedor INT NULL,
ADD CONSTRAINT fk_productos_proveedores 
FOREIGN KEY (id_proveedor) REFERENCES proveedores(id_proveedor)
ON DELETE RESTRICT ON UPDATE CASCADE;

-- 3. Insertar un proveedor de prueba por defecto
INSERT INTO proveedores (nombre, RUC, telefono, correo) 
VALUES ('Distribuidora El Tornillo', 'J0310000123456', '88884444', 'ventas@eltornillo.com');