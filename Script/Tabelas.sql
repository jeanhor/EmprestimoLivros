CREATE TABLE CLIENTE
(

    id int IDENTITY(1,1) PRIMARY KEY,
	cliCpf			   VARCHAR (14) NULL,
	cliNome		       VARCHAR (200) NOT NULL,
	cliendereco  	   VARCHAR (200) NULL,
	cliCidade   	   VARCHAR (200) NULL,
	cliBairro   	   VARCHAR (50) NULL,
	cliNumero     	   VARCHAR (50) NULL,
	cliTelefoneCelular VARCHAR (50) NULL,
	cliTelefoneFixo    VARCHAR (50) NULL,
)


CREATE TABLE LIVRO
(
	id int IDENTITY(1,1) PRIMARY KEY,
	livroNome	        VARCHAR  (50) NULL,
	livroAutor		    VARCHAR  (200) NOT NULL,
	livroEditora  	    VARCHAR  (200) NULL,
	livroAnoPublicacao  datetime,
	livroEducao   	    VARCHAR  (50) NULL,
)
CREATE TABLE Livro_Cliente_Emprestimo
(
	id	                INT NOT NULL,
	LceIdCliente        INT NOT NULL,
	lceIdLivro          INT NOT NULL,
	LceDataEmprestimo   DateTime,
	LceDataEntrega      DateTime,
	LceEntrega          bit,
	CONSTRAINT PK_Livro_Cliente_Emprestimo PRIMARY KEY (id)
)