-- Inserir autores
INSERT INTO authors (id, name, email)
VALUES
  ('d86fcbbf-4635-4f91-9d85-03b4bbed79a1', 'Autor 1', 'autor1@example.com'),
  ('c20e83e2-1f94-421f-8f91-b5ea9e8e0f48', 'Autor 2', 'autor2@example.com'),
  ('27e01ed5-1c27-4b8b-9b92-7c0ea89c1c6b', 'Autor 3', 'autor3@example.com');

-- Inserir posts relacionados aos autores
INSERT INTO posts (id, title, slug, content, authorId, thumb)
VALUES
  ('2f42ed82-52ad-4fc6-84e9-20bfe3840b1b', 'Título da Postagem 1', 'titulo-postagem-1', 'Conteúdo da postagem 1...', 'd86fcbbf-4635-4f91-9d85-03b4bbed79a1', 'thumb1.jpg'),
  ('25f7a67a-6c0e-465b-9d1d-58d96a7c76f0', 'Título da Postagem 2', 'titulo-postagem-2', 'Conteúdo da postagem 2...', 'd86fcbbf-4635-4f91-9d85-03b4bbed79a1', 'thumb2.jpg'),
  
  ('e4c901d6-2192-475e-af92-58921ca2439c', 'Título da Postagem 3', 'titulo-postagem-3', 'Conteúdo da postagem 3...', 'c20e83e2-1f94-421f-8f91-b5ea9e8e0f48', 'thumb3.jpg'),
  ('f2d8f1a1-1cc4-414a-9a3b-08bdc879f214', 'Título da Postagem 4', 'titulo-postagem-4', 'Conteúdo da postagem 4...', 'c20e83e2-1f94-421f-8f91-b5ea9e8e0f48', 'thumb4.jpg'),
  
  ('0310f5a0-7b82-47ca-9bc9-97efdf5a39ef', 'Título da Postagem 5', 'titulo-postagem-5', 'Conteúdo da postagem 5...', '27e01ed5-1c27-4b8b-9b92-7c0ea89c1c6b', 'thumb5.jpg'),
  ('19203e95-60b4-4d2c-8d17-20ff1fb17f94', 'Título da Postagem 6', 'titulo-postagem-6', 'Conteúdo da postagem 6...', '27e01ed5-1c27-4b8b-9b92-7c0ea89c1c6b', 'thumb6.jpg');
