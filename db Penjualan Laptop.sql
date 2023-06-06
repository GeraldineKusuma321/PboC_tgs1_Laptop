CREATE TABLE laptop 
(
    nama VARCHAR(255),
    harga INTEGER,
    stok INTEGER
)

select * from laptop



CREATE TABLE transaksi
(
    identitas_transaksi VARCHAR(255),
    nama VARCHAR(255)
)

select * from transaksi

CREATE TABLE detail_transaksi
(
    transaksi VARCHAR(255),
    laptop_dibeli VARCHAR(255),
    stok_dibeli INTEGER
)

select * from detail_transaksi