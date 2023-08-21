CREATE EXTENSION pg_trgm;

CREATE TABLE IF NOT EXISTS author (
  id UUID PRIMARY KEY,
  name TEXT NOT NULL,
  email TEXT NOT NULL
);

CREATE TABLE IF NOT EXISTS posts (
  id UUID PRIMARY KEY,
  title TEXT UNIQUE NOT NULL,
  slug TEXT UNIQUE NOT NULL,
  content TEXT NOT NULL,
  authorId UUID NOT NULL,
  thumb TEXT NOT NULL,
  FOREIGN KEY (authorId) REFERENCES author(id)
);


CREATE INDEX post_title ON posts(title);
CREATE INDEX author_name ON author(name);