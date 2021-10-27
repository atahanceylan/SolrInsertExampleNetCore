# SolrInsertExampleNetCore
Solr Search Engine Insert Example in .Net Core
Project Using Details

1) In powershell run docker-compose -f docker-compose.solr.yml up This will start solr container. 
You check Solr is working on your local via http://localhost:8983/solr/#/ URL from browser.
![Solr query](https://github.com/atahanceylan/SolrInsertExampleNetCore/blob/main/solr_query.PNG)

2) When you run project you will be able to insert post to Solr document database.
![Swagger UI](https://github.com/atahanceylan/SolrInsertExampleNetCore/blob/main/swagger_ui_solr_insert.PNG)
This project built based on https://stacksecrets.com/dot-net-core/integrate-solr-instance-with-net-core article

