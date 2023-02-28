CREATE TABLE Funcionarios (
  CPF INTEGER UNSIGNED NOT NULL,
  nome VARCHAR(45) NULL,
  endereco VARCHAR(45) NULL,
  telefone INTEGER UNSIGNED NULL,
  salario DECIMAL NULL,
  funcao VARCHAR(20) NULL,
  PRIMARY KEY(CPF)
);

CREATE TABLE Usuarios (
  CPF INTEGER UNSIGNED NOT NULL,
  nome VARCHAR(45) NULL,
  endereco VARCHAR(45) NULL,
  telefone INTEGER UNSIGNED NULL,
  PRIMARY KEY(CPF)
);

CREATE TABLE Editoras (
  codigo_editora INTEGER UNSIGNED NOT NULL,
  nome VARCHAR(45) NULL,
  endereco VARCHAR(45) NULL,
  contato VARCHAR(45) NULL,
  PRIMARY KEY(codigo_editora)
);

CREATE TABLE Autores (
  codigo INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  nome VARCHAR(45) NULL,
  nacionalidade VARCHAR(20) NULL,
  PRIMARY KEY(codigo)
);

CREATE TABLE Livros (
  numero INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  Usuarios_CPF INTEGER UNSIGNED NOT NULL,
  Editoras_codigo_editora INTEGER UNSIGNED NOT NULL,
  Funcionarios_CPF INTEGER UNSIGNED NOT NULL,
  titulo VARCHAR(20) NULL,
  genero VARCHAR(20) NULL,
  edicao INT(2) NULL,
  ano_publicacao INT(4) NULL,
  PRIMARY KEY(numero),
  INDEX Livros_FKIndex1(Funcionarios_CPF),
  INDEX Livros_FKIndex2(Editoras_codigo_editora),
  INDEX Livros_FKIndex3(Usuarios_CPF),
  INDEX Livros_FKIndex4(Usuarios_CPF),
  FOREIGN KEY(Funcionarios_CPF)
    REFERENCES Funcionarios(CPF)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION,
  FOREIGN KEY(Editoras_codigo_editora)
    REFERENCES Editoras(codigo_editora)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION,
  FOREIGN KEY(Usuarios_CPF)
    REFERENCES Usuarios(CPF)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION,
  FOREIGN KEY(Usuarios_CPF)
    REFERENCES Usuarios(CPF)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION
);

CREATE TABLE Autores_has_Livros (
  Autores_codigo INTEGER UNSIGNED NOT NULL,
  Livros_numero INTEGER UNSIGNED NOT NULL,
  PRIMARY KEY(Autores_codigo, Livros_numero),
  INDEX Livros_Autores(Autores_codigo),
  INDEX Autores_has_Livros_FKIndex2(Livros_numero),
  FOREIGN KEY(Autores_codigo)
    REFERENCES Autores(codigo)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION,
  FOREIGN KEY(Livros_numero)
    REFERENCES Livros(numero)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION
);


