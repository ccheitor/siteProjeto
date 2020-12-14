Telas
        ◦ CADASTRO CLIENTE 
            ▪ Ao cadastrar o cliente o status “Nome disponível”;
            ▪ Campos obrigatórios o preenchimento.
              
        ◦ OFERTA
            ▪ Ao cadastrar uma oferta ao cliente, deverá ser alterado o status do cliente;
            ▪ Para realizar uma oferta, deverá ser pesquisado um cliente pelo Nome ou CPF ;
            ▪ O cliente que estiver com status finalizado (o status do cliente seja “FINALIZA CLIENTE” = Sim) não deverá aparecer mais na pesquisa. 
            ▪ Após ser feita a pesquisa, em uma lista de resultados, poderá ser selecionado um dos clientes e ser realizada a oferta (utilizar um botão “Ofertar”). 
            ▪ Após selecionado o cliente, deverá ser apresentado a listagem de campos abaixo (item 2.2.1 Listagem Campos). 
              
              
 Entidades e Relacionamentos
       
    1. Cadastro Cliente 
        1. Nome (Obrigatório)
        2. CPF (Obrigatório)
        3. Credito
        4. Telefone(Obrigatório)
        5. Status Atual
           
    2. Endereço de Entrega 
        1. Cep 
        2. Rua 
        3. Numero
        4. Complemento
        5. Bairro
        6. Cidade
        7. Estado
           
    3. Produtos
        1. Descrição 
        2. Preço 
        3. Tipo 
            1. Hardware
            2. Software
        4. Código do Produto 

    4. Status
        1. Descrição
        2. Finaliza Cliente(bol)
        3. Contabiliza Venda(bol)
        4. Código Status 
           

API REST
    • Criar uma API REST para consumir os dados da aplicação
