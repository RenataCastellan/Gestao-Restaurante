create database bd_restaurante;
use bd_restaurante;

create table funcionario(
id_fun int primary key auto_increment,
nome_fun varchar(300),
dataNascimento_fun date,
email_fun varchar(300),
funcao_fun varchar(300),
telefone_fun varchar(100),
cpf_fun varchar(100),
salario_fun double
);

create table Cliente(
id_cli int primary key auto_increment,
nome_cli varchar(300),
cpf_cli varchar(100),
dataNascimento_cli date,
telefone_cli varchar(100),
email_cli varchar(300),
preferenciasAlimentares_cli varchar(300)
);

create table Fornecedor(
id_for int primary key auto_increment,
nome_for varchar(300),
cpnj_for varchar(100),
telefone_for varchar(100),
email_for varchar(100),
status_for ENUM('Ativo', 'Inativo') not null
);

create table Caixa(
id_cai int primary key auto_increment,
saldoInicial_cai double,
totalRecebimento_cai double,
saldoFinal_cai double,
dataMovimentacao_cai date
);

create table Mesa(
id_mesa int primary key auto_increment,
status_mesa ENUM('Ativo', 'Inativo') not null,
numero_mesa int,
capacidade_mesa int
);

create table Produto(
id_prod int primary key auto_increment,
nome_prod varchar(300),
estoque_prod int,
valor_prod double,
descricao_prod varchar(300),
categoria_prod ENUM('Alimento', 'Bebida', 'Material de Limpeza', 'Outros') NOT NULL
);

create table Pedido(
id_ped int primary key auto_increment,
hora_ped time,
valor_ped double,
status_ped ENUM('Recebido', 'Em Preparo', 'Pronto', 'Entregue', 'Cancelado'),

id_mesa_fk int not null,
foreign key (id_mesa_fk) references Mesa (id_mesa),

id_fun_fk int not null,
foreign key (id_fun_fk) references Funcionario (id_fun)
);

create table Pedido_Produto(
id_ped_pro int primary key auto_increment,
quantidade_ped_pro int,

id_prod_fk int not null,
foreign key (id_prod_fk) references Produto (id_prod),

id_ped_fk int not null,
foreign key (id_ped_fk) references Pedido (id_ped)
);

create table Compra(
id_com int primary key auto_increment,
data_com date,
total_com double,
status_com ENUM('Pendente', 'Pago', 'Cancelado') NOT NULL DEFAULT 'Pendente',
formaPgto_com ENUM('Dinheiro', 'Cartão Crédito', 'Cartão Débito', 'Pix') NOT NULL,

id_fun_fk int not null,
foreign key (id_fun_fk) references Funcionario (id_fun),

id_for_fk int not null,
foreign key (id_for_fk) references Fornecedor (id_for)
);

create table Compra_Produto(
id_com_pro int primary key auto_increment,
quantidade_com_pro int,

id_prod_fk int not null,
foreign key (id_prod_fk) references Produto (id_prod),

id_com_fk int not null,
foreign key (id_com_fk) references Compra (id_com)
);

create table Venda(
id_ven int primary key auto_increment,
valor_ven double,
formaPgto_com ENUM('Dinheiro', 'Cartão Crédito', 'Cartão Débito', 'Pix') NOT NULL,

id_fun_fk int not null,
foreign key (id_fun_fk) references Funcionario (id_fun),

id_cli_fk int not null,
foreign key (id_cli_fk) references Cliente (id_cli),

id_ped_fk int not null,
foreign key (id_ped_fk) references Pedido (id_ped)
);

create table Refeicao(
id_ref int primary key auto_increment,
kilo_ref double,
descricao_ref varchar(300),
preco_ref double,
tempoPreparo time,

id_ven_fk int not null,
foreign key (id_ven_fk) references Venda (id_ven)
);

create table Pedido_Refeicao(
id_ped_ref int primary key auto_increment,

id_ped_fk int not null,
foreign key (id_ped_fk) references Pedido (id_ped),

id_ref_fk int not null,
foreign key (id_ref_fk) references Refeicao (id_ref)
);

create table Venda_Produto(
id_ven_pro int primary key auto_increment,

id_ven_fk int not null,
foreign key (id_ven_fk) references Venda (id_ven),

id_prod_fk int not null,
foreign key (id_prod_fk) references Produto (id_prod)
);

create table Recebimento(
id_rec int primary key auto_increment,
valor_rec double,
status ENUM('Confirmado', 'Pendente', 'Cancelado') NOT NULL,

id_ven_fk int not null,
foreign key (id_ven_fk) references Venda (id_ven),

id_cai_fk int not null,
foreign key (id_cai_fk) references Caixa (id_cai)
);