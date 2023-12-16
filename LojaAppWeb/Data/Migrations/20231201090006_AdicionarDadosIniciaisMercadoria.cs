using LojaAppWeb.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LojaAppWeb.Data.Migrations;

/// <inheritdoc />
public partial class AdicionarDadosIniciaisMercadoria : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        var context = new LojaDbContext();
        context.Mercadoria.AddRange(ObterCargaInicialMercadoria());
        context.SaveChanges();

    }

    private IList<Mercadoria> ObterCargaInicialMercadoria()
    {
        return new List<Mercadoria>()
        {
            new Mercadoria
            {
                Nome = "Ancho Intermezzo",
                Descricao = "Conhecido como noix, filé de costela, ancho, \"ojo de bife\", ribeye ou entrecot. É retirado da região lombar (contrafilé). Muito saboroso, macio e suculento, tem fibras mais curtas e macias.",
                ImagemUri = "/images/01_ancho_intermezzo.webp",
                Preco = 67.00,
                EntregaExpressa = true,
                DataCadastro = DateTime.Now,
                MarcaId = 1,
            },
            new Mercadoria
            {
                Nome = "Prime Rib Bassi Marfrig",
                Descricao = "A peça de prime rib inteira é serrada na transversal, seguindo o sentido dos ossos da costela revestido por carne. Carne de alta qualidade que reúne em um só corte o marmoreio, a gordura entremeada nas fibras, e o sabor especial que o osso oferece.",
                ImagemUri = "/images/02_prime_rib_bassi_marfrig.webp",
                Preco = 156.00,
                EntregaExpressa = false,
                DataCadastro = DateTime.Now,
                MarcaId = 2,
            },
            new Mercadoria
                {
                    Nome = "Ancho Bassi Marfrig",
                    Descricao = "Conhecido como noix, filé de costela, ancho, \"ojo de bife\", ribeye ou entrecot. É retirado da região lombar (contrafilé). Muito saboroso, macio e suculento, tem fibras mais curtas e macias.",
                    ImagemUri = "/images/03_ancho_bassi_marfrig.webp",
                    Preco = 85.00,
                    EntregaExpressa = true,
                    DataCadastro = DateTime.Now,
                    MarcaId = 2,
                },
            new Mercadoria
                {
                    Nome = "T-Bone Intermezzo",
                    Descricao = "Corte especial do lombo do animal que engloba contrafilé e filé mignon divididos por um osso em formato de T. É uma carne muito saborosa, macia e entremeada de gordura.",
                    ImagemUri = "/images/04_t_bone_intermezzo.webp",
                    Preco = 189.00,
                    EntregaExpressa = false,
                    DataCadastro = DateTime.Now,
                    MarcaId = 1,
                },
            new Mercadoria
                {
                    Nome = "Shoulder Angus VPJ",
                    Descricao = "Corte especial do lombo do animal que engloba contrafilé e filé mignon divididos por um osso em formato de T. É uma carne muito saborosa, macia e entremeada de gordura.",
                    ImagemUri = "/images/05_shoulder_angus_vpj.webp",
                    Preco = 159.00,
                    EntregaExpressa = true,
                    DataCadastro = DateTime.Now,
                    MarcaId = 3,
                },
            new Mercadoria
                {   Nome = "Flat Iron Intermezzo",
                    Descricao = "Corte retirada da paleta, mais especificamente da raquete que também é conhecida como shoulder. É um corte muito macio e marmorizado.",
                    ImagemUri = "/images/06_flat_iron_intermezzo.webp",
                    Preco = 209.00,
                    EntregaExpressa = false,
                    DataCadastro = DateTime.Now,
                    MarcaId = 1,
                },
            new Mercadoria
                {
                    Nome = "Picanha Angus Bassi Marfrig",
                    Descricao = "Corte macio e com capa de gordura. Tem sabor acentuado, sendo o corte \"preferido\" dos brasileiros. Muito suculenta, podendo ser assada inteira ou grelhada em postas/tiras. É importante o preparo com a capa de gordura para que o sabor e suculência fiquem mais acentuados.",
                    ImagemUri = "/images/07_picanha_angus_bassi_marfrig.webp", Preco = 199.00,
                    EntregaExpressa = true,
                    DataCadastro = DateTime.Now,
                    MarcaId = 2,
                },
            new Mercadoria
                {   Nome = "Bombom de Alcatra Angus Intermezzo",
                    Descricao = "Corte brasileiro normalmente preparado em medalhões como o filé mignon. Corte extremamente macio, de sabor acentuado e com pouquíssima gordura.",
                    ImagemUri = "/images/08_bombom_alcatra_intermezzo.webp", Preco = 149.00,
                    EntregaExpressa = false,
                    DataCadastro = DateTime.Now,
                    MarcaId = 1,
                },
            new Mercadoria
                {
                    Nome = "MaminhaBassi Marfrig",
                    Descricao = "Corte retirado da ponta da alcatra, possui capa de gordura, é suculenta e tem sabor suave. Deve ser cortada de forma correta, ou seja, contra as fibras, para acentuar sua maciez e sabor.",
                    ImagemUri = "/images/09_maminha_bassi_marfrig.webp",
                    Preco = 89.00,
                    EntregaExpressa = false,
                    DataCadastro = DateTime.Now,
                    MarcaId = 2,
                },
            new Mercadoria
                {
                    Nome = "Tomahawk Angus Cara Preta",
                    Descricao = "É uma versão do prime rib de 1kg, porém com osso longo da costela de aproximadamente 28cm. Seu formato remete a uma ferramenta de uso indígena com aparência de um machado, cujo nome é tomahawk. Tem a suculência, sabor e maciez do filé de costela, justamente com o sabor que o osso empresta a carne.",
                    ImagemUri = "/images/10_Tomahawk_cara_preta.webp",
                    Preco = 260.00,
                    EntregaExpressa = true,
                    DataCadastro = DateTime.Now,
                    MarcaId = 4,
                },
            new Mercadoria
                {   Nome = "Hamburguer Wagyu Intermezzo",
                    Descricao = "Por possuir alto grau de marmoreio - gordura entremeada nas fibras - e atributos de qualidade superior que garantem maior sabor e maciez nos preparos, a carne de Wagyu foi declarada tesouro do território japonês em 1997.",
                    ImagemUri = "/images/11_hamburguer_wagyu_intermezzo.webp",
                    Preco = 68.00,
                    EntregaExpressa = true,
                    DataCadastro = DateTime.Now,
                    MarcaId = 1,
            },
            new Mercadoria
                {   Nome = "Pão de Alho Tradicional D'Pão",
                    Descricao = "Pão de Alho Tradicional D'Pão.",
                    ImagemUri = "/images/12_pao_de_alho_tradicional_dpao.webp",
                    Preco = 14.00,
                    EntregaExpressa = true,
                    DataCadastro = DateTime.Now,
                    MarcaId = 6,
                },
            new Mercadoria
                {   Nome = "Molho Chimichurri 200g Cantagallo",
                    Descricao = "O molho chimichurri é tradicional na Argentina e combina com todos os cortes de carne e acrescenta mais sabor às receitas. Esse mix de ervas pode ser utilizado sobre carnes assadas ou grelhadas, ou ainda pode ser servido como aperitivo para acompanhar pães, pizzas, batatas assadas e saladas.",
                    ImagemUri = "/images/13_molho_chimichurri_200g_cantagallo.webp",
                    Preco = 42.00,
                    EntregaExpressa = true,
                    DataCadastro = DateTime.Now,
                    MarcaId = 5,
                },
        };
    }
    
}
