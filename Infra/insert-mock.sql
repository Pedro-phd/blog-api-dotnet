-- Inserir autores
INSERT INTO author (id, name, email)
VALUES
  ('a0eebc99-9c0b-4ef8-bb6d-6bb9bd380a11', 'Autor 1', 'autor1@example.com'),
  ('c4ca4238-a0b9-3382-8dcc-509a6f75849b', 'Autor 2', 'autor2@example.com'),
  ('c81e728d-9d4c-3d8a-5e27-8d5d5f0a9402', 'Autor 3', 'autor3@example.com'),
  ('eccbc87e-4b5c-37a3-7f5e-8c91f6af5e2b', 'Autor 4', 'autor4@example.com'),
  ('a87ff679-a2f3-7465-7a7b-8b1fc16b3f4d', 'Autor 5', 'autor5@example.com');

-- Inserir postagens relacionadas a autores
INSERT INTO posts (id, title, slug, content, authorId, thumb)
VALUES
  ('f47ac10b-58cc-4372-a567-0e02b2c3d479', 'Título da Postagem 1', 'titulo-postagem-1', 'Conteúdo da postagem 1...', 'a0eebc99-9c0b-4ef8-bb6d-6bb9bd380a11', 'thumb-1.jpg'),
  ('1f0e3dad-9a3c-37eb-3a9b-4ff2e03e5866', 'Título da Postagem 2', 'titulo-postagem-2', 'Conteúdo da postagem 2...', 'c4ca4238-a0b9-3382-8dcc-509a6f75849b', 'thumb-2.jpg'),
  ('0cc175b9-c0f1-c15e-3ce4-ecbda3abc5ad', 'Título da Postagem 3', 'titulo-postagem-3', 'Conteúdo da postagem 3...', 'c81e728d-9d4c-3d8a-5e27-8d5d5f0a9402', 'thumb-3.jpg'),
  ('4e732ced-3b7f-48e4-85de-6110aa5b4b5b', 'Título da Postagem 4', 'titulo-postagem-4', 'Conteúdo da postagem 4...', 'eccbc87e-4b5c-37a3-7f5e-8c91f6af5e2b', 'thumb-4.jpg'),
  ('8e296aeb-9d4c-3190-3e7c-ecbc9fca46e1', 'Título da Postagem 5', 'titulo-postagem-5', 'Conteúdo da postagem 5...', 'a87ff679-a2f3-7465-7a7b-8b1fc16b3f4d', 'thumb-5.jpg');
