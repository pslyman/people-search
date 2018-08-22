<template>

<div class="container-fluid">
    <div class="header">
      <h1>{{ msg }}</h1>
    </div>
    <div class="row">
      <div class="col-md-12">
        <!-- <clip-loader v-if="tableLoading"></clip-loader> -->

        <b-form-input v-model="search" type="text" placeholder="Search by name"></b-form-input>

        <table class="table table-striped table-bordered table-sm">

            <thead>
              <tr>
                <th @click="sort('name')">Name</th>
                <th @click="sort('age')">Age</th>
                <th @click="sort('eyecolor')">Eye Color</th>
                <th @click="sort('address')">Address</th>
                <th @click="sort('fact')">Fact</th>
                <th>Avatar</th>
              </tr>
            </thead>
            <tbody>
              <tr v-for="people in filteredPeople" v-bind:key="people.name">
                <td>{{people.name}}</td>
                <td>{{people.age}}</td>
                <td>{{people.eyecolor}}</td>
                <td>{{people.address}}</td>
                <td>{{people.fact}}</td>
                <td><img class='images' :src='people.image' alt="image placeholder"></td>
              </tr>
            </tbody>
          </table>
        <p>
<!--           <button @click="prevPage">Previous</button>
          <button @click="nextPage">Next</button> -->
        </p>

      </div>
    </div>
</div>

</template>

<script>
/* import ClipLoader from 'vue-spinner/src/PulseLoader.vue' */

export default {
  name: 'PeopleSearch',
  data () {
    return {
      msg: 'People Search',
      search: '',
      people: [
        {name: 'Jared Johnson',
          age: 33,
          eyecolor: 'Blue',
          address: '1234 Avenue',
          fact: 'Likes ketchup on most everything',
          image: 'https://api.adorable.io/avatars/285/jared@adorable.io.png'},
        {name: 'Katherine Ayne',
          age: 21,
          eyecolor: 'Brown Bakerson',
          address: '1234 Pkwy',
          fact: 'Saw a kangaroo once',
          image: 'https://api.adorable.io/avatars/285/katherine@adorable.io.png'},
        {name: 'Katy Courts',
          age: 45,
          eyecolor: 'Brown Calebs',
          address: '1234 Cir',
          fact: 'Reads LotR fan-fiction for fun',
          image: 'https://api.adorable.io/avatars/285/katy@adorable.io.png'},
        {name: 'James Hansen',
          age: 32,
          eyecolor: 'Green',
          address: '1234 Way',
          fact: 'Writes a lot of LotR fan-fiction',
          image: 'https://api.adorable.io/avatars/285/james@adorable.io.png'},
        {name: 'Jonathan Greendale',
          age: 70,
          eyecolor: 'Blue',
          address: '1234 St',
          fact: 'Uses peppermint toothpaste like a weirdo',
          image: 'https://api.adorable.io/avatars/285/jonathan@adorable.io.png'},
        {name: 'Jessica Fern',
          age: 20,
          eyecolor: 'Hazel',
          address: '1234 Road',
          fact: 'Grows her own parsley in her backyard',
          image: 'https://api.adorable.io/avatars/285/jessica@adorable.io.png'},
        {name: 'Jordan Kale',
          age: 50,
          eyecolor: 'Hazel',
          address: '1234 Ln',
          fact: 'Owns three gorgeous cats: Fergeson, Jeffrey, and Monica',
          image: 'https://api.adorable.io/avatars/285/jordan@adorable.io.png'}
      ]
    }
  },
  computed: {
    filteredPeople: function () {
      return this.people.filter((person) => {
        return person.name.toLowerCase().includes(this.search.toLowerCase())
      })
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
img {
  width: 50px;
  border-radius: 50%;
}
h1, h2 {
  font-weight: normal;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
