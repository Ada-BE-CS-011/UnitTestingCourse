using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestsFundamentals.UnitTests
{
    public class SaqueTestData : TheoryData<int, Dictionary<int, int>>
    {
        public SaqueTestData()
        {
            //Add(2, new Dictionary<int, int> 
            //{
            //    { 200, 0 },
            //    { 100, 0 },
            //    {  50, 0 },
            //    {  20, 0 },
            //    {  10, 0 },
            //    {   5, 0 },
            //    {   2, 1 },
            //});

            //Add(5, new Dictionary<int, int>
            //{
            //    { 200, 0 },
            //    { 100, 0 },
            //    {  50, 0 },
            //    {  20, 0 },
            //    {  10, 0 },
            //    {   5, 1 },
            //    {   2, 0 },
            //});

            //Add(9, new Dictionary<int, int>
            //{
            //    { 200, 0 },
            //    { 100, 0 },
            //    {  50, 0 },
            //    {  20, 0 },
            //    {  10, 0 },
            //    {   5, 1 },
            //    {   2, 2 },
            //});

            //Add(8, new Dictionary<int, int>
            //{
            //    { 200, 0 },
            //    { 100, 0 },
            //    {  50, 0 },
            //    {  20, 0 },
            //    {  10, 0 },
            //    {   5, 0 },
            //    {   2, 4 },
            //});

            //Add(11, new Dictionary<int, int>
            //{
            //    { 200, 0 },
            //    { 100, 0 },
            //    {  50, 0 },
            //    {  20, 0 },
            //    {  10, 0 },
            //    {   5, 1 },
            //    {   2, 3 },
            //});

            Add(41, new Dictionary<int, int>
            {
                 // 6 + 35 => 20 + 10 + 5 + 3*2
                { 200, 0 },
                { 100, 0 },
                {  50, 0 },
                {  20, 1 },
                {  10, 1 },
                {   5, 1 },
                {   2, 3 },
            });
        }
    }
}
